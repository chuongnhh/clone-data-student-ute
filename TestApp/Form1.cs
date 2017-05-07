using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Form1 : Form
    {
        private string url = "https://online.hcmute.edu.vn/";
        private int startIndex = 0;
        private int endIndex = 0;
        private StudentDbContext db = new StudentDbContext();
        private Config config = new Config();

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(700, 500);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            config = (new StudentDbContext()).Configs.FirstOrDefault();
            startIndex = config.StartIndex;
            endIndex = config.EndIndex;
            textStartIndex.Text = startIndex.ToString();
            textEndIndex.Text = endIndex.ToString();

            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            textStartIndex.Text = startIndex.ToString();
            textEndIndex.Text = endIndex.ToString();
            textLink.Text = webBrowser1.Url.AbsoluteUri;

            // đăng nhập
            if (webBrowser1.Url.AbsoluteUri == (url + "dangnhapnhaphoso.aspx"))
            {
                var txtUsername = webBrowser1.Document.GetElementById("txtTaiKhoan");
                txtUsername.InnerText = startIndex.ToString();
                var txtPassword = webBrowser1.Document.GetElementById("txtMatKhau");
                txtPassword.InnerText = startIndex.ToString();

                var btnLogin = webBrowser1.Document.GetElementById("btnDangNhap");
                btnLogin.InvokeMember("click");
                startIndex++;
            }

            // đăng nhập ok
            if (webBrowser1.Url.AbsoluteUri == (url + "ThongTinTuyenSinh.aspx"))
            {
                Student student = new Student();
                //Thread.Sleep(10);
                // đoc dữ liệu ở đây
                var studentCode = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtMaSinhVien");
                student.StudentCode = studentCode.GetAttribute("value");

                var firstName = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtHo");
                student.FirstName = firstName.GetAttribute("value");

                var lastName = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtTen");
                student.LastName = lastName.GetAttribute("value");

                var gender = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_chkGioiTinh");
                student.Gender = gender.GetAttribute("checked");

                var birthDay = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtNgaySinh");
                student.Birthday = birthDay.GetAttribute("value");

                var email = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtEmailCaNhan");
                student.Email = email.GetAttribute("value");

                var phoneNumber = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtSoDienThoai");
                student.PhoneNumber = phoneNumber.GetAttribute("value");

                var idCard = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtCMND");
                student.IDCard = idCard.GetAttribute("value");

                var homeNumber = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtSoNha");
                student.HomeNumber = homeNumber.GetAttribute("value");

                var address = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtTenDuong");
                student.Address = address.GetAttribute("value") + ", " +
                    webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtPhuongXaThiTran").GetAttribute("value");

                student.SetFullName();
                db.Students.Add(student);
                db.SaveChanges();
                textStudentCount.Text = db.Students.Count().ToString();
                // chuyển trang/ đăng xuất
                var btnClose = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_lnkThoatTaiKhoan");
                btnClose.InvokeMember("click");
                webBrowser1.Navigate(url + "dangnhapnhaphoso.aspx");
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new FrmConfig()).ShowDialog();

            config = (new StudentDbContext()).Configs.FirstOrDefault();
            startIndex = config.StartIndex;
            endIndex = config.EndIndex;
            textStartIndex.Text = startIndex.ToString();
            textEndIndex.Text = endIndex.ToString();
        }

        private void startAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(url + "dangnhapnhaphoso.aspx");
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //webBrowser1.Navigate(url + "dangnhapnhaphoso.aspx");
        }
    }
}
