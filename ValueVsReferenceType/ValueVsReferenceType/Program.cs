using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 5;
            int secondValue = firstValue;
            Console.WriteLine("First Value " + firstValue + " Second Value " + secondValue);
            firstValue = 10; //update second value
            Console.WriteLine("First Value " + firstValue + " Second Value " + secondValue);
            //References r1 = new References();
            //r1.firstValue = 5;
            //References r2 = r1;
            //Console.WriteLine("First Value " + r1.firstValue + " Second Value " + r2.firstValue);
            //r2.firstValue = 10;//update value
            //Console.WriteLine("First Value " + r1.firstValue + " Second Value " + r2.firstValue);
            Console.ReadLine();
        }
    }
}
