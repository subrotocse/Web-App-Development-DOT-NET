using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Nid No");
            string nid = Console.ReadLine();
            Person aPerson = new Person();
            Console.WriteLine("Please Enter Your First Name");
            string firstName=Console.ReadLine();

            if(firstName.Length==5)
            {
                aPerson.FirstName = firstName;
                string firstname = aPerson.FirstName;
                Console.WriteLine(firstname);
            }
            else if (nid.Length != 5)
            {
                Console.WriteLine("First Name Must Be 5 Character");
            }
            if (nid.Length == 5)
            {
                aPerson.Nid = nid;
                string id = aPerson.Nid;
                Console.WriteLine(id);
            }
            else if (nid.Length != 5)
            {
                Console.WriteLine("Value Must Be 5 Character");
            }
            aPerson = new Person("subroto", "ghosh", "subro");
            string fullName = aPerson.GetFullName();
            Console.WriteLine(fullName);
         
            Console.ReadLine();
        }
    }
}
