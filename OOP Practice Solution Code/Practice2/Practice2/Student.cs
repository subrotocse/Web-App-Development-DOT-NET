using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Student
    {
        public string RegNo { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string GetStudentFullInformation()
        {
            return "      "+RegNo+"       "+Name+"      "+Email+"\n";
        }
    }
}
