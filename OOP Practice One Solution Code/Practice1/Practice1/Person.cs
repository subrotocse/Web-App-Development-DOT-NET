using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName,string middleName,string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }
        public Person(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string GetFullName()
        {
            return FirstName + "  " + MiddleName + "  " + LastName; 
        }
        public string GetFullNameTwo() 
        {
            return FirstName + "   " + LastName;
        }
    }
}
