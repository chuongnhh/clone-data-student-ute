using Newtonsoft.Json;
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
    public partial class FrmMainOnline : Form
    {
        private string _baseUrl = "https://online.hcmute.edu.vn/";

        private string _studentID1;
        private string _studentID2;
        private string _studentID3;
        private int _studentID4 = 1;

        private StudentDbContext db = new StudentDbContext();
        private BindingSource _bindingSource = new BindingSource();

        public FrmMainOnline()
        {
            InitializeComponent();
            this.Size = new Size(730, 500);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Data data = new Data();
            //data.Students = db.Students.ToList();
            //string output = JsonConvert.SerializeObject(data);

            _bindingSource.DataSource = db.Students.OrderByDescending(x => x.DateCreate).ToList();
            dataGridView1.DataSource = _bindingSource;
            // Khóa tuyển sinh
            List<StudentID> _listStudentID1 = new List<StudentID>();

            for (int i = 17; i >= 10; i--)
            {
                _listStudentID1.Add(new StudentID
                {
                    Key = "Khóa " + i.ToString() + " (K" + i.ToString() + ")",
                    Value = i.ToString()
                });
            }
            comboBoxStudentID1.DataSource = _listStudentID1;
            comboBoxStudentID1.ValueMember = "Value";
            comboBoxStudentID1.DisplayMember = "Key";
            // Mã hệ đào tạo
            List<StudentID> _listStudentID2 = new List<StudentID>();

            List<string> _value2 = new List<string> { "1", "2", "3", "4", "5", "6", "7", "B", "D", "9" };
            List<string> _key2 = new List<string> {
                "Đại học chính quy (ĐHCQ)",
                "Đại học chính quy khối K-3/7 (ĐHK3/7)",
                "Đại học chính quy hệ chuyển tiếp (ĐHCT)",
                "Đại học tại chức (ĐHTC)",
                "Đại học tại chức khối K-3/7 (ĐHTC3/7)",
                "Đại học tại chức hệ hoàn chỉnh (ĐHTCHC)",
                "Đại học chính quy (CĐCQ)",
                "Đại học chính quy văn bằng 2",
                "Đại học chuyên nghiệp hệ chính quy (THCN)",
                "Sư phạm"
            };
            foreach (var item in _value2)
            {
                _listStudentID2.Add(new StudentID
                {
                    Key = _key2[_value2.IndexOf(item)],
                    Value = item
                });
            }
            comboBoxStudentID2.DataSource = _listStudentID2;
            comboBoxStudentID2.ValueMember = "Value";
            comboBoxStudentID2.DisplayMember = "Key";
            // Mã ngành
            List<StudentID> _listStudentID3 = new List<StudentID>();
            List<string> _value3 = new List<string> {
                "41", "42", "19", "51", "43", "04", "44", "46", "45",
                "47","49","09","23","52","25","24","50","16","48","10","50" };
            List<string> _key3 = new List<string> {
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
            for (int i = 0; i < _value3.Count(); i++)
            {
                _listStudentID3.Add(new StudentID
                {
                    Key = _key3[i],
                    Value = _value3[i]
                });
            }
            comboBoxStudentID3.DataSource = _listStudentID3;
            comboBoxStudentID3.ValueMember = "Value";
            comboBoxStudentID3.DisplayMember = "Key";
            // Khóa tuyển sinh + Mã hệ đào tạo + Mã ngành + STT SV

            labelStartIndex.Text = getStudentID();
            labelEndIndex.Text = getStudentID();
            labelCountItem.Text = (new StudentDbContext()).Students.Count().ToString();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string _fullStudentCode = getStudentID();

            labelStartIndex.Text = _fullStudentCode.ToString();

            // đăng nhập
            if (webBrowser1.Url.AbsoluteUri.Equals(_baseUrl + "dangnhapnhaphoso.aspx"))
            {
                var _username = webBrowser1.Document.GetElementById("txtTaiKhoan");
                _username.InnerText = _fullStudentCode.ToString();
                var _password = webBrowser1.Document.GetElementById("txtMatKhau");
                _password.InnerText = _fullStudentCode.ToString();

                var _login = webBrowser1.Document.GetElementById("btnDangNhap");
                _login.InvokeMember("click");
                _studentID4++;
            }

            // đăng nhập ok
            if (webBrowser1.Url.AbsoluteUri.Equals(_baseUrl + "ThongTinTuyenSinh.aspx"))
            {

                // Đọc/ và lưu dữ liệu
                Student _student = getStudentInfo();

                if (db.Students.Find(_student.StudentID) == null)
                {
                    db.Students.Add(_student);
                    db.SaveChanges();
                    labelCountItem.Text = db.Students.Count().ToString();
                    _bindingSource.DataSource = db.Students.OrderByDescending(x => x.DateCreate).ToList();

                    labelMessage.Text = "Items " + _student.StudentID + " - " + _student.FullName + " saved successfully.";
                }
                else
                    labelMessage.Text = "Items " + _student.StudentID + " - " + _student.FullName + " already exists";
                // chuyển trang/ đăng xuất
                var _close = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_lnkThoatTaiKhoan");
                _close.InvokeMember("click");
                webBrowser1.Navigate(_baseUrl + "dangnhapnhaphoso.aspx");
            }
        }

        private void comboBoxStudentID1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _studentID1 = comboBoxStudentID1.SelectedValue.ToString();
            labelEndIndex.Text = getStudentID();
            labelStartIndex.Text = getStudentID();
        }

        private void comboBoxStudentID2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _studentID2 = comboBoxStudentID2.SelectedValue.ToString();
            labelEndIndex.Text = getStudentID();
            labelStartIndex.Text = getStudentID();
        }

        private void comboBoxStudentID3_SelectedIndexChanged(object sender, EventArgs e)
        {
            _studentID3 = comboBoxStudentID3.SelectedValue.ToString();
            labelEndIndex.Text = getStudentID();
            labelStartIndex.Text = getStudentID();
        }

        private string getStudentID()
        {
            return _studentID1 + _studentID2 + _studentID3 + _studentID4.ToString("000");
        }

        private void enableControls(bool value)
        {
            comboBoxStudentID1.Enabled = value;
            comboBoxStudentID2.Enabled = value;
            comboBoxStudentID3.Enabled = value;
            buttonReset.Enabled = value;
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text.Contains("Start"))
            {
                webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
                buttonStart.Text = "Pause";
                enableControls(false);
            }
            else if (buttonStart.Text.Contains("Pause"))
            {
                webBrowser1.DocumentCompleted -= webBrowser1_DocumentCompleted;
                buttonStart.Text = "Start";
                enableControls(true);
            }
            webBrowser1.Navigate(_baseUrl + "dangnhapnhaphoso.aspx");
        }

        private void reset_Click(object sender, EventArgs e)
        {
            _studentID4 = 1;
            labelStartIndex.Text = getStudentID();
            labelEndIndex.Text = getStudentID();
        }


        private Student getStudentInfo()
        {
            Student _student = new Student();

            // Mã số sinh viên
            var _studentID = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtMaSinhVien");
            _student.StudentID = _studentID.GetAttribute("value");

            // Họ và chữ lót
            var _firstName = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtHo");
            _student.FirstName = _firstName.GetAttribute("value");

            // Tên
            var _lastName = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtTen");
            _student.LastName = _lastName.GetAttribute("value");

            // Giới tính
            var _gender = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_chkGioiTinh");
            _student.Gender = _gender.GetAttribute("checked");

            // Ngày sinh
            var _birthOfDate = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtNgaySinh");
            _student.BirthOfDate = _birthOfDate.GetAttribute("value");

            // Nơi sinh
            var _placeOfBirth = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtNoiSinh");
            _student.PlaceOfBirth = _placeOfBirth.GetAttribute("value");

            // Dân tộc
            var _nation = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_ddlDanToc");
            dynamic domNation = _nation.DomElement;
            int indexNation = (int)domNation.selectedIndex();
            if (indexNation != -1)
            {
                _student.Nation = _nation.Children[indexNation].InnerText;
            }

            // Tôn giáo
            var _religion = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_ddlTonGiao");
            dynamic _domReligion = _religion.DomElement;
            int _indexReligion = (int)_domReligion.selectedIndex();
            if (_indexReligion != -1)
            {
                _student.Religion = _religion.Children[_indexReligion].InnerText;
            }

            // Địa chỉ email
            var _emailAddress = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtEmailCaNhan");
            _student.EmailAddress = _emailAddress.GetAttribute("value");

            // Số điện thoại
            var _phoneNumber = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtSoDienThoai");
            _student.PhoneNumber = _phoneNumber.GetAttribute("value");

            // Chứng minh thư
            var _identityCard = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtCMND");
            _student.IdentityCard = _identityCard.GetAttribute("value");
          
            // Ngày cấp chứng minh thư
            var _dateOfIssueOfIidentificationCard = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_RadDateNgayCapCMND_dateInput");
            _student.DateOfIssueOfIidentificationCard = _dateOfIssueOfIidentificationCard.GetAttribute("value");
          
            // Nơi cấp chứng minh thư
            var _placeOfIssuanceOfIdentityCard = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtNoiCapCMND");
            _student.PlaceOfIssuanceOfIdentityCard = _placeOfIssuanceOfIdentityCard.GetAttribute("value");

            // Thành phần xuất thân
            var _worker = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_rdblThanhPhanXuatThan_0");
            _student.Worker = _worker.GetAttribute("checked");
            var _farmer = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_rdblThanhPhanXuatThan_1");
            _student.Farmer = _farmer.GetAttribute("checked");
            var _officersAndEmployees = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_rdblThanhPhanXuatThan_2");
            _student.OfficersAndEmployees = _officersAndEmployees.GetAttribute("checked");

            // Hội-Lớp đã từng trải 
            var _classOrSocietyHasExperienced = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtTenChucVuDoanHoiLop");
            _student.ClassOrSocietyHasExperienced = _classOrSocietyHasExperienced.GetAttribute("value");

            // Năng khiếu
            var _gifted = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtNangKhieu");
            _student.Gifted = _gifted.GetAttribute("value");

            // Thành tích
            var _achievement = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtThanhTich");
            _student.Achievement = _achievement.GetAttribute("value");
            
            // Khen thưởng và kỹ luật
            var _commendationOrDiscipline = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtKyLuat");
            _student.CommendationOrDiscipline = _commendationOrDiscipline.GetAttribute("value");

            // Số nhà
            var _homeNumber = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtSoNha");
            _student.HomeNumber = _homeNumber.GetAttribute("value");

            // Tóm tắt quá trình học tập và lao động (ghi rõ thời gian, nơi học tập, công tác, lao động)
            var _summaryOfLearningProcess = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtTomTatQuaTrinhHocTaoLaoDong");
            _student.SummaryOfLearningProcess = _summaryOfLearningProcess.GetAttribute("value");

            // Tên đường,phố/ấp thôn 
            var _roadNameOrHamlet = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtTenDuong");
            _student.RoadNameOrHamlet = _roadNameOrHamlet.GetAttribute("value");

            // Phường/Xã/Thị trấn
            var _wardOrCommuneOrTown = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtPhuongXaThiTran");
            _student.WardOrCommuneOrTown = _wardOrCommuneOrTown.GetAttribute("value");

            // Tỉnh/ thành phố
            var _provinceOrCity = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_ddlTinhThanh");
            dynamic _domProvinceOrCity = _provinceOrCity.DomElement;
            int _indexProvinceOrCity = (int)_domProvinceOrCity.selectedIndex();
            if (_indexProvinceOrCity != -1)
            {
                _student.ProvinceOrCity = _provinceOrCity.Children[_indexProvinceOrCity].InnerText;
            }

            // Quận/huyện/Thị xã
            var _districtOrDistrictOrTown = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_ddlQuanHuyen");
            dynamic _domDistrictOrDistrictOrTown = _districtOrDistrictOrTown.DomElement;
            int _indexDistrictOrDistrictOrTown = (int)_domDistrictOrDistrictOrTown.selectedIndex();
            if (_indexDistrictOrDistrictOrTown != -1)
            {
                _student.DistrictOrDistrictOrTown = _districtOrDistrictOrTown.Children[_indexDistrictOrDistrictOrTown].InnerText;
            }


            // Thông tin thân nhân

            // Họ và tên cha/ mẹ
            var _fatherName = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtHoTenCha");
            _student.FatherFullName = _fatherName.GetAttribute("value");

            var _motherName = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtHoTenMe");
            _student.MotherFullName = _motherName.GetAttribute("value");

            // Dân tộc của cha/ mẹ
            var _fatherNation = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_ddlDanTocCha");
            dynamic _domFatherNation = _fatherNation.DomElement;
            int _indexFatherNation = (int)_domFatherNation.selectedIndex();
            if (_indexFatherNation != -1)
            {
                _student.FatherNation = _fatherNation.Children[_indexFatherNation].InnerText;
            }

            var _motherNation = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_ddlDanTocMe");
            dynamic _domMotherNation = _motherNation.DomElement;
            int _indexMotherNation = (int)_domMotherNation.selectedIndex();
            if (_indexMotherNation != -1)
            {
                _student.MotherNation = _motherNation.Children[_indexMotherNation].InnerText;
            }

            // Tôn giáo của cha/ mẹ
            var _fatherReligion = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_ddlDanTocCha");
            dynamic _domFatherReligion = _fatherReligion.DomElement;
            int _indexFatherReligion = (int)_domFatherReligion.selectedIndex();
            if (_indexFatherReligion != -1)
            {
                _student.FatherReligion = _fatherReligion.Children[_indexFatherReligion].InnerText;
            }

            var _motherReligion = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_ddlDanTocMe");
            dynamic _domMotherReligion = _motherReligion.DomElement;
            int _indexMotherReligion = (int)_domMotherReligion.selectedIndex();
            if (_indexMotherReligion != -1)
            {
                _student.MotherNation = _motherReligion.Children[_indexMotherReligion].InnerText;
            }

            // Quốc tịch của cha/ mẹ
            var _fatherCitizenship = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_ddlQuocTichCha");
            dynamic _domFatherCitizenship = _fatherCitizenship.DomElement;
            int _indexFatherCitizenship = (int)_domFatherCitizenship.selectedIndex();
            if (_indexFatherCitizenship != -1)
            {
                _student.FatherCitizenship = _fatherCitizenship.Children[_indexFatherCitizenship].InnerText;
            }

            var _motherCitizenship = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_ddlQuocTichMe");
            dynamic _domMotherCitizenship = _motherCitizenship.DomElement;
            int _indexMotherCitizenship = (int)_domMotherCitizenship.selectedIndex();
            if (_indexMotherCitizenship != -1)
            {
                _student.MotherCitizenship = _motherCitizenship.Children[_indexMotherCitizenship].InnerText;
            }

            // Hộ khẩu thường trú của cha/ mẹ
            var _fatherPermanentResidence = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtHoKhauThuongTruCha");
            _student.FatherPermanentResidence = _fatherPermanentResidence.GetAttribute("value");

            var _motherPermanentResidence = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtHoKhauThuongTruMe");
            _student.MotherPermanentResidence = _motherPermanentResidence.GetAttribute("value");

            // Nghề nghiệp của  cha/ mẹ
            var _fatherJob = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtNgheNghiepCha");
            _student.FatherJob = _fatherJob.GetAttribute("value");

            var _motherJob = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtNgheNghiepMe");
            _student.MotherJob = _motherJob.GetAttribute("value");


            // Số điện thoại của cha/ mẹ
            var _fatherPhoneNumber = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtDienThoaiCha");
            _student.FatherPhoneNumber = _fatherPhoneNumber.GetAttribute("value");

            var _motherPhoneNumber = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtDienThoaiMe");
            _student.MotherPhoneNumber = _motherPhoneNumber.GetAttribute("value");


            // Năm sinh của cha/ mẹ
            var _fatherBirthOfDate = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtNamSinhCha");
            _student.FatherBirthOfDate = _fatherBirthOfDate.GetAttribute("value");

            var _motherBirthOfDate = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtNamSinhMe");
            _student.MotherBirthOfDate = _motherBirthOfDate.GetAttribute("value");

            // Họ và tên, nghề nghiệp, nơi ở của anh chị em ruột
            var _fullNameOccupationPlaceOfSibling = webBrowser1.Document.GetElementById("NhapThongTinTuyenSinh1_txtHoTenNgheNghiepNoiOACERout");
            _student.FullNameOccupationPlaceOfSibling = _fullNameOccupationPlaceOfSibling.GetAttribute("value");


            _student.SetFullName();
            _student.CourseEnrollment = comboBoxStudentID1.Text;
            _student.SystemTraining = comboBoxStudentID2.Text;
            _student.IndustryOrFaculty = comboBoxStudentID3.Text;

            return _student;
        }
    }
}
