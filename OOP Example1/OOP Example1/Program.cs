using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////////....... how value type work...............///////////
             //int a = 10;
            //int b = a;
            //Console.WriteLine(b);
            //a = 300;
            //b = 100;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //..........How references type work.............without constructor/////////
            //Person aPerson = new Person();
            //aPerson.firstName = "subroto";
            //aPerson.middleName = "ghosh";
            //aPerson.lastName = "subro";

            //...........Constructor And Constructor Overloading.............//////
            Person aPerson = new Person();
            aPerson.nId = "20779279179";     //search a person by his nid
           
            //aPerson = new Person("subrato", "Ghosh");
            aPerson = new Person("subroto", "ghosh", "subro");
            string fullName = aPerson.GetFullName();
            Console.WriteLine(fullName);
            Console.ReadLine();
        }
    }
}
