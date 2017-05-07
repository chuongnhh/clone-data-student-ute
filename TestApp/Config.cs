using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Config
    {
        [Key]
        public int Id { get; set; }
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
    }
}
