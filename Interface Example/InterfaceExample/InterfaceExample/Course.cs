using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Course:IBasicInfo,IPrint
    {
        public string CourseTitle { get; set; }
        public string CourseCode { get; set; }


        public string GetBasicInfo()
        {
            return CourseTitle + "  " + CourseCode + " ";
        }

        public void Print()
        {
            Console.WriteLine("I print call");
        }
    }
}
