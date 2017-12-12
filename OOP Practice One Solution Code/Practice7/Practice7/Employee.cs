using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7
{
    class Employee
    {
        public string Id { get; set;}
        public string Name { get; set;}
        public string Email { get; set;}
        public Salary EmployeeSalary { get; set;}

        public Employee ()
        {
            EmployeeSalary = new Salary();
        }
    }
}
