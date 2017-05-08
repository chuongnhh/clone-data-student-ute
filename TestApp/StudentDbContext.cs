using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext():base("name=DefaultConnection")
        {

        }

        public virtual DbSet<Student> Students { get; set; }
    }
}
