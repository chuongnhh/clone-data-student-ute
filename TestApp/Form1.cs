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
        //private int startIndex = 0;
        //private int endIndex = 0;
        private StudentDbContext db = new StudentDbContext();

        private string yearCode;
        private string levelCode;
        private string facultyCode;
        private int index = 1;
        //private string studentCode;

        private BindingSource bd = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(700, 500);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bd.DataSource = (new StudentDbContext()).Students.OrderByDescending(x => x.Id).ToList();
            dataGridView1.DataSource = bd;
            // Khóa tuyển sinh
            List<Code> lst1 = new List<Code>();

            for (int i = 17; i >= 10; i--)
            {
                lst1.Add(new Code
                {
                    Key = "Khóa " + i.ToString() + " (K" + i.ToString() + ")",
                    Value = i.ToString()
                });
            }
            comboBox1.DataSource = lst1;
            comboBox1.ValueMember = "Value";
            comboBox1.DisplayMember = "Key";
            // Mã hệ đào tạo
            List<Code> lst2 = new List<Code>();

            List<string> value2 = new List<string> { "1", "2", "3", "4", "5", "6", "7", "B", "D", "9" };
            List<string> key2 = new List<string> {
                "ĐH chính quy (ĐHCQ)",
                "ĐH chính quy khối K-3/7 (ĐHK3/7)",
                "ĐH chính quy hệ chuyển tiếp (ĐHCT)",
                "ĐH tại chức (ĐHTC)",
                "ĐH tại chức khối K-3/7 (ĐHTC3/7)",
                "ĐH tại chức hệ hoàn chỉnh (ĐHTCHC)",
                "CĐ chính quy (CĐCQ)",
                "ĐH chính quy văn bằng 2",
                "TC chuyên nghiệp hệ chính quy (THCN)",
                "Sư phạm"
            };
            foreach (var item in value2)
            {
                lst2.Add(new Code
                {
                    Key = key2[value2.IndexOf(item)],
                    Value = item
                });
            }
            comboBox2.DataSource = lst2;
            comboBox2.ValueMember = "Value";
            comboBox2.DisplayMember = "Key";
            // Mã ngành
            List<Code> lst3 = new List<Code>();
            List<string> value3 = new List<string> {
                "41", "42", "19", "51", "43", "04", "44", "46", "45",
                "47","49","09","23","52","25","24","50","16","48","10","50" };
            List<string> key3 = new List<string> {
                "CNKT điện tử, truyền thông (KĐĐ)",
                "CNKT Điện, điện tử (Điện công nghiệp - ĐKC)",
                "CN Kỹ thuật máy tính (KMT)",
                "CNKT điều khiển và tự động hóa (Điện tự động - ĐTĐ)",
                "Công nghệ chế tạo máy (CKM)",
                "Kỹ thuật công nghiệp (KCN)",
                "CNKT cơ khí (CTĐ)",
                "CNKT cơ điện tử (CĐT)",
                "CNKT ô tô (CKĐ)",
                "CNKT nhiệt (NĐL)",
                "CNKT công trình xây dựng (XDC)",
                "Công nghệ may (CNM)",
                "Thiết kế thời trang (TKT)",
                "Kinh tế gia đình (Kỹ thuật nữ công - KNC)",
                "Kế toán (KTO)",
                "Quản lý công nghiệp (QLC)",
                "CNKT Môi trường (CMT)",
                "Công nghệ thực phẩm (CTP)",
                "Công nghệ in (KTI)",
                "Công nghệ thông tin (CNT)",
                "Sư phạm tiếng Anh (AV-SP)"
            };
            foreach (var item in value3)
            {
                lst3.Add(new Code
                {
                    Key = key3[value3.IndexOf(item)],
                    Value = item
                });
            }
            comboBox3.DataSource = lst3;
            comboBox3.ValueMember = "Value";
            comboBox3.DisplayMember = "Key";
            // Khóa tuyển sinh + Mã hệ đào tạo + Mã ngành + STT SV

            textStartIndex.Text = getStudentCode();
            textEndIndex.Text = getStudentCode();
            textStudentCount.Text = db.Students.Count().ToString();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string code = getStudentCode();

            textStartIndex.Text = code.ToString();
            textLink.Text = webBrowser1.Url.AbsoluteUri;

            // đăng nhập
            if (webBrowser1.Url.AbsoluteUri == (url + "dangnhapnhaphoso.aspx"))
            {
                var txtUsername = webBrowser1.Document.GetElementById("txtTaiKhoan");
                txtUsername.InnerText = code.ToString();
                var txtPassword = webBrowser1.Document.GetElementById("txtMatKhau");
                txtPassword.InnerText = code.ToString();

                var btnLogin = webBrowser1.Document.GetElementById("btnDangNhap");
                btnLogin.InvokeMember("click");
                index++;
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
                bd.DataSource = (new StudentDbContext()).Students.OrderByDescending(x => x.Id).ToList();
                // chuyển trang/ đăng xuất
                var btnClose = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_lnkThoatTaiKhoan");
                btnClose.InvokeMember("click");
                webBrowser1.Navigate(url + "dangnhapnhaphoso.aspx");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearCode = comboBox1.SelectedValue.ToString();
            textEndIndex.Text = getStudentCode();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            levelCode = comboBox2.SelectedValue.ToString();
            textEndIndex.Text = getStudentCode();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            facultyCode = comboBox3.SelectedValue.ToString();
            textEndIndex.Text = getStudentCode();
        }

        private string getStudentCode()
        {
            return yearCode + levelCode + facultyCode + index.ToString("000");
        }

        private void enableControls(bool value)
        {
            comboBox1.Enabled = value;
            comboBox2.Enabled = value;
            comboBox3.Enabled = value;
            button2.Enabled = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(url + "dangnhapnhaphoso.aspx");
            if (button1.Text.Contains("Start"))
            {
                webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
                button1.Text = "Pause";
                enableControls(false);
            }
            else
            {
                webBrowser1.DocumentCompleted -= webBrowser1_DocumentCompleted;
                button1.Text = "Start";
                enableControls(true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = 1;
            textStartIndex.Text = getStudentCode();
            textEndIndex.Text = getStudentCode();
        }
    }
}
