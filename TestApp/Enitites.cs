using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Code
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class Student
    {
        public Student()
        {
            FullName = FirstName + " " + LastName;
        }
        [Key]
        public int Id { get; set; }
        public string StudentCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Email { get; set; }
        public string IDCard { get; set; }
        public string PhoneNumber { get; set; }
        public string HomeNumber { get; set; }
        public string Address { get; set; }

        public void SetFullName()
        {
            FullName = FirstName + " " + LastName;
        }
    }
}
