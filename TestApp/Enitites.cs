using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Data
    {
        public List<Student> Students { get; set; }
    }
    public class StudentID
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class Student
    {
        public Student()
        {
            FullName = FirstName + " " + LastName;
            DateCreate = DateTime.Now;
        }
        /// <summary>
        /// Mã số sinh viên
        /// </summary>
        [Key]
        [Display(Name = "Mã số sinh viên")]
        public string StudentID { get; set; }
        /// <summary>
        /// Họ lót
        /// </summary>
        [Display(Name = "Họ lót")]
        public string FirstName { get; set; }
        /// <summary>
        /// Tên
        /// </summary>
        [Display(Name = "Tên")]
        public string LastName { get; set; }
        /// <summary>
        /// Họ và tên
        /// </summary>
        [Display(Name = "Họ và tên")]
        public string FullName { get; set; }
        /// <summary>
        /// Giới tính
        /// </summary>
        [Display(Name = "Giới tính")]
        public string Gender { get; set; }
        /// <summary>
        /// Ngày sinh
        /// </summary>
        [Display(Name = "Ngày sinh")]
        public string BirthOfDate { get; set; }
        /// <summary>
        /// Nơi sinh
        /// </summary>
        [Display(Name = "Nơi sinh")]
        public string PlaceOfBirth { get; set; }
        /// <summary>
        /// Địa chỉ email
        /// </summary>
        [Display(Name = "Địa chỉ email")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Sô chứng minh thư
        /// </summary>
        [Display(Name = "Sô chứng minh thư")]
        public string IdentityCard { get; set; }
        /// <summary>
        /// Ngày cấp chứng minh thư
        /// </summary>
        [Display(Name = "Ngày cấp chứng minh thư")]
        public string DateOfIssueOfIidentificationCard { get; set; }
        /// <summary>
        /// Nơi cấp chứng minh thư
        /// </summary>
        [Display(Name = "Nơi cấp chứng minh thư")]
        public string PlaceOfIssuanceOfIdentityCard { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Số nhà
        /// </summary>
        [Display(Name = "Số nhà")]
        public string HomeNumber { get; set; }

        /// <summary>
        /// Ngành/ Khóa
        /// </summary>
        [Display(Name = "Ngành/ Khóa")]
        public string IndustryOrFaculty { get; set; }
        /// <summary>
        /// Khóa tuyển sinh
        /// </summary>
        [Display(Name = "Khóa tuyển sinh")]
        public string CourseEnrollment { get; set; }
        /// <summary>
        /// Hệ đào tạo
        /// </summary>
        [Display(Name = "Hệ đào tạo")]
        public string SystemTraining { get; set; }

        // Thành phần xuất thân
        /// <summary>
        /// Là công nhân
        /// </summary>
        [Display(Name = "Là công nhân")]
        public string Worker { get; set; }
        /// <summary>
        /// Là nông dân
        /// </summary>
        [Display(Name = "Là nông dân")]
        public string Farmer { get; set; }
        /// <summary>
        /// Là cán bộ, công nhân viên
        /// </summary>
        [Display(Name = "Là cán bộ, công nhân viên")]
        public string OfficersAndEmployees { get; set; }

        /// <summary>
        /// Hội/ Lớp đã từng trải 
        /// </summary>
        [Display(Name = "Hội/ Lớp đã từng trải ")]
        public string ClassOrSocietyHasExperienced { get; set; }
        /// <summary>
        /// Thành tích
        /// </summary>
        [Display(Name = "Thành tích")]
        public string Achievement { get; set; }

        /// <summary>
        /// Năng khiếu
        /// </summary>
        [Display(Name = "Năng khiếu")]
        public string Gifted { get; set; }

        /// <summary>
        /// Tóm tắc quá trình học tập
        /// </summary>
        [Display(Name = "Tóm tắc quá trình học tập")]
        public string SummaryOfLearningProcess { get; set; }

        /// <summary>
        /// Khen thưởng/ kỷ luật
        /// </summary>
        [Display(Name = "Khen thưởng/ kỷ luật")]
        public string CommendationOrDiscipline { get; set; }

        /// <summary>
        /// Tôn giáo
        /// </summary>
        [Display(Name = "Tôn giáo")]
        public string Religion { get; set; }
        /// <summary>
        /// Dân tộc
        /// </summary>
        [Display(Name = "Dân tộc")]
        public string Nation { get; set; }

        /// <summary>
        /// Tên đường, phố/ ấp thôn
        /// </summary>
        [Display(Name = "Tên đường, phố/ ấp thôn")]
        public string RoadNameOrHamlet { get; set; }
        /// <summary>
        /// Phường/ Xã/ Thị trấn
        /// </summary>
        [Display(Name = "Phường/ Xã/ Thị trấn")]
        public string WardOrCommuneOrTown { get; set; }
        /// <summary>
        /// Tỉnh/ Thành phố
        /// </summary>
        [Display(Name = "Tỉnh/ Thành phố")]
        public string ProvinceOrCity { get; set; }
        /// <summary>
        /// Quận/ Huyện/ Thị xã
        /// </summary>
        [Display(Name = "Quận/ Huyện/ Thị xã")]
        public string DistrictOrDistrictOrTown { get; set; }

        /// <summary>
        /// Họ và tên, nghề nghiệp, nơi ở của anh chị em ruột
        /// </summary>
        [Display(Name = "Họ và tên, nghề nghiệp, nơi ở của anh chị em ruột")]
        public string FullNameOccupationPlaceOfSibling { get; set; }

        //=======================================================================

        /// <summary>
        /// Họ tên của mẹ
        /// </summary>
        [Display(Name = "Họ tên của mẹ")]
        public string MotherFullName { get; set; }
        /// <summary>
        /// Họ tên của cha
        /// </summary>
        [Display(Name = "Họ tên của cha")]
        public string FatherFullName { get; set; }

        /// <summary>
        /// Nghề nghiệp của mẹ
        /// </summary>
        [Display(Name = "Nghề nghiệp của mẹ")]
        public string MotherJob { get; set; }
        /// <summary>
        /// Nghề nghiệp của cha
        /// </summary>
        [Display(Name = "Nghề nghiệp của cha")]
        public string FatherJob { get; set; }

        /// <summary>
        /// Số điện thoại của mẹ
        /// </summary>
        [Display(Name = "Số điện thoại của mẹ")]
        public string MotherPhoneNumber { get; set; }
        /// <summary>
        /// Số điện thoại của cha
        /// </summary>
        [Display(Name = "Số điện thoại của cha")]
        public string FatherPhoneNumber { get; set; }

        /// <summary>
        /// Quốc tịch của mẹ
        /// </summary>
        [Display(Name = "Quốc tịch của mẹ")]
        public string MotherCitizenship { get; set; }
        /// <summary>
        /// Quốc tịch của cha
        /// </summary>
        [Display(Name = "Quốc tịch của cha")]
        public string FatherCitizenship { get; set; }

        /// <summary>
        /// Dân tôc của mẹ
        /// </summary>
        [Display(Name = "Dân tôc của mẹ")]
        public string MotherNation { get; set; }
        /// <summary>
        /// Dân tôc của cha
        /// </summary>
        [Display(Name = "Dân tôc của cha")]
        public string FatherNation { get; set; }

        /// <summary>
        /// Tôn giáo của mẹ
        /// </summary>
        [Display(Name = "Tôn giáo của mẹ")]
        public string MotherReligion { get; set; }
        /// <summary>
        /// Tôn giáo của cha
        /// </summary>
        [Display(Name = "Tôn giáo của cha")]
        public string FatherReligion { get; set; }

        /// <summary>
        /// Hộ khẩu thường trú của mẹ
        /// </summary>
        [Display(Name = "Hộ khẩu thường trú của mẹ")]
        public string MotherPermanentResidence { get; set; }
        /// <summary>
        /// Hộ khẩu thường trú của cha
        /// </summary>
        [Display(Name = "Hộ khẩu thường trú của cha")]
        public string FatherPermanentResidence { get; set; }

        /// <summary>
        /// Năm sinh của mẹ
        /// </summary>
        [Display(Name = "Năm sinh của mẹ")]
        public string MotherBirthOfDate { get; set; }
        /// <summary>
        /// Năm sinh của cha
        /// </summary>
        [Display(Name = "Năm sinh của cha")]
        public string FatherBirthOfDate { get; set; }

        [Display(Name = "Ngày khởi tạo")]
        public DateTime DateCreate { get; set; }

        public void SetFullName()
        {
            FullName = FirstName + " " + LastName;
        }
    }
}
