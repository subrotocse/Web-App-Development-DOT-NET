using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToOneAssociation
{
    class Person
    {
        public string FirstName{ get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
       public Address personAddress { get; set; }
        public string GetFullInformation()
        {
            return FirstName + "  " + MiddleName + "  " + LastName;
        }
    }
}
