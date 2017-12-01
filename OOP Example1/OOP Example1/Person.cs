using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example1
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string nId;
        public Person(string firstName,string middleName,string lastName)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Person()
        {
 
        }
        public string GetFullName()
        {           
            return "First Name : "+firstName+"\nMiddle Name : "+middleName+"\nLast Name : "+lastName;
        }
    }
}
