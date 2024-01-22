using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EF6_Code_First_App
{
    class Program
    {
        public static object stud { get; private set; }
        public static object Paul { get; private set; }
       
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName ="Paul" };
                ctx.StudentsTable.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
