using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person("Subroto", "Ghosh", "Subro");
            Person bPerson = new Person("subro", "ghosh");
            string name1=aPerson.GetFullName();
           string name2= bPerson.GetFullNameTwo();
           Console.WriteLine(name1);
           Console.WriteLine(name2);
           Console.ReadLine();
        }
    }
}
