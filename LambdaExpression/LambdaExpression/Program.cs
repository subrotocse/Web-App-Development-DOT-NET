using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        //delegate int Increment(int x);
        //delegate int Decrement(int y);
        static void Main(string[] args)
        {
            Func<int, int> incrementMethod;   //**Lambda Expression       //delegate (int z){return z+1;};//Delegate
            incrementMethod = y => y + 20;                 //** Lambda Expression     //delegate(int d) {return d+4 ;};//Delegate
           int results=incrementMethod.Invoke(20);
           int results1 = incrementMethod.Invoke(2);
           Console.WriteLine(results + " " + results1);

           Func<int, int> method1 = x => { return x * 2; };
           int method1Result = method1.Invoke(2);
           Console.WriteLine(method1Result);

           Func<int, int, decimal> method2 = (x, y) => x / y;
           decimal method2Result = method2.Invoke(3, 2);
           Console.WriteLine(method2Result);

           Console.ReadLine();
        }
    }
}
