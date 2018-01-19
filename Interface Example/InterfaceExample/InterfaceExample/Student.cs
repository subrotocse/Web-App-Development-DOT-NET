using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Student:IBasicInfo,IPrint
    {
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Email{ get; set; }
        public string PhoneNo { get; set; }

        public string GetBasicInfo()
        {
            return Name + " " + RegNo + " " + Email + " " + PhoneNo; 
        }

        public void Print()
        {
            Console.WriteLine("I print call");
        }
    }
}
