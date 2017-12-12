using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssociation
{
    class Department
    {
        public string DepartmentName{ get; set; }
        public string DepartmentCode { get; set; }
        public List<Student> StudentList { get; set; }
        public Department(string departmentName, string departmentCode)
        {
            DepartmentName = departmentName;
            DepartmentCode = departmentCode;
        }
        public Department()
        {
            StudentList = new List<Student>();
        }
        public string GetDepartInformation()
        {
            return " " + DepartmentName + " " + DepartmentCode + " " + StudentList;
        }
    }
}
