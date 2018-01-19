using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student();
            aStudent.GetBasicInfo();
            Course aCourse = new Course();
            aCourse.GetBasicInfo();
            IPrint p = aCourse;
            IBasicInfo basicInfo = aCourse;
            p.Print();                    // IPrint behaviour 
            basicInfo.GetBasicInfo();     // IBasicInfo Behaviour
            aCourse.GetBasicInfo();       //Course Behaviour
            Department aDepartment = new Department();
            aDepartment.GetBasicInfo();

        }
    }
}
