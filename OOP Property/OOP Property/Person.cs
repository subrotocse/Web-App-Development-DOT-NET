using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Property
{
    class Person
    {
        // Field Must Be Private because of anyone in other class can't  use it.

           private string firstName;
           private string middleName;
           private string lastName;
           private string nId;

        // Nid length Check (logic check)/ Property in C#
           public string Nid
           { 
               set 
               {
                   if (value.Length == 5)
                   {                                   
                       nId = value;
                   }
              }
               get { return nId; }
           }

        // First Name Logic Check / C# Property
           public string FirstName
           { 
               
               set
               {
                   if(value.Length==5)
                   {
                     firstName=value;
                   }
               }
               get
               {
                   return firstName;
               }
           }
            public Person(string firstName, string middleName, string lastName)
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
                return "First Name : " + firstName + "\nMiddle Name : " + middleName + "\nLast Name : " + lastName;
            }
        
    }
}
