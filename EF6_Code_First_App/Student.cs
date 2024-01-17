using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EF6_Code_First_App
{
        [Table("tblStudent")]
        public class Student
        {
            [Key] 
            public int studentID { get; set; }
            public string studentName { get; set; }
        public string StudentName { get; internal set; }
        public byte[] photo { get; set; }
            public decimal Height { get; set; }
            public float weight { get; set; }

            public Grade Grade { get; set; }
        }
    
}

