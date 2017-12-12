using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Department
    {
        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public List<Student> StudentList { get; set; }
        public string GetDepartmentFullInformation()
        {
            return "                     " + DepartmentCode + "                 " + DepartmentName;
        }
        public Department()
        {
            StudentList = new List<Student>();
        }
    }
}
