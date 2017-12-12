using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeVsReferenceType
{
    class Program
    {
        /// <summary>
        /// How  Value Type work
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
                int a = 10;
                Change(a);
                Console.WriteLine(a);
                Console.ReadLine();
            }
            static void Change(int b)
            {
                b = 20;
                int a = b;
            }

               /// How Reference Type work
               /// 

        //    Employee aEmployee = new Employee();
        //    aEmployee.firstName = "subroto";
        //    aEmployee.secondName = "ghosh";
        //    aEmployee.lastName = "subro";
        //    Change(aEmployee);
        //    Console.WriteLine(aEmployee.firstName + aEmployee.lastName + aEmployee.secondName);
        //    Console.ReadLine();
        //}
        //static void Change(Employee aEmployee)
        //{
        //    aEmployee.firstName = "ghosh";
        //    aEmployee.lastName = "subro";
        //}
    }
}
