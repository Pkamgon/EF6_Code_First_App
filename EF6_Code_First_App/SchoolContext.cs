using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EF6_Code_First_App
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
            : base("name=StudentDb") => _ = StudentsTable;
        public DbSet<Student> StudentsTable { get; set; }
        public DbSet<Grade> GradesTable { get; set; }
        public object Students { get; internal set; }
        public object Student { get; internal set; }

    }
}
