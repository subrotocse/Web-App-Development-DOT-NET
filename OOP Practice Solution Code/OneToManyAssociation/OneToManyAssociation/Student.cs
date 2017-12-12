using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyAssociation
{
    class Student
    {
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }

        public Student(string name,string regNo,string email,string contactNo)
        {
            Name = name;
            RegNo = regNo;
            Email = email;
            ContactNo = contactNo;
        }
        public Student()
        {

        }
        public string GetFullInformation()
        {
            return "  " + Name + "  " + RegNo + "  " + Email + "  " + ContactNo;
        }
    }
}
