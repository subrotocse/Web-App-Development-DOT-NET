using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
          Employee aEmployee = new Employee("subroto","ghosh","subro");
          Employee bEmployee = new Employee("subro","roy");
          string fullname1= aEmployee.GetEmployeeFullName();
          string fullname2= bEmployee.GetEmployeeFullName();
          Console.WriteLine(fullname1);
          Console.WriteLine(fullname2);
          Employee employee = new Employee();
          employee.Salary = 20000;
          employee.Bonus = 2000;
          double totalSalary= employee.GetSalaryWithBonus();
          Console.WriteLine("Total Salary Eith Bonus"+totalSalary);
          Console.ReadLine();
        }
    }
}
