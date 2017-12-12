using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesRelationshipAndConstructorCalling
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee aEmployee = new Employee("subroto","Ghosh","subro");
            Employee bEmployee = new Employee("subro","chowdary","ddd");
            Employee cEmployee = new Employee();
            
            aEmployee.BasicSalary = 30000;
            aEmployee.Bonus = 5000;
            double totalSalary = aEmployee.GetSalaryWithBonus();
            Console.WriteLine(aEmployee.FirstName+" "+aEmployee.MiddleName+" "+aEmployee.LastName);
            Console.WriteLine(bEmployee.FirstName+" "+bEmployee.LastName);
            Console.WriteLine("Total Salary "+totalSalary);
            Console.ReadLine();
        }
    }
}
