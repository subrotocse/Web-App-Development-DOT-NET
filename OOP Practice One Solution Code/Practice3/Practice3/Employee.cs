using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Employee
    {
        public string FirstName{ get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public double Bonus{ get; set; }
        public Employee(string firstName,string middleName,string lastName):this( firstName,lastName)
        {
            //FirstName = firstName;
            MiddleName = middleName;
            //LastName = lastName;
        }
        public Employee(string firstName,string lastName):this()
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Employee()
        {
            Salary = 0;
            Bonus = 0;
        }
        public string GetEmployeeFullName()
        {
            if (MiddleName == null)
            {
                return FirstName + "  " + LastName;
            }
            else
            {
                return FirstName + " " + MiddleName + " " + LastName;
            }
        }
        public double GetSalaryWithBonus()
        {
            //return Salary + Bonus;
            Calculator aCalculator = new Calculator();
            return aCalculator.Add(Salary, Bonus);
        }
    }
}
