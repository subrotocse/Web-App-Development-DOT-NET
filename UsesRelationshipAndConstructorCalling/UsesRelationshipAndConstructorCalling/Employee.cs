using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsesRelationshipAndConstructorCalling
{
    class Employee
    {
        public string  FirstName{ get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public double BasicSalary { get; set; }
        public double Bonus { get; set; }
        public Employee(string firstName,string middleName,string lastName):this(firstName,lastName)
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
            BasicSalary = 0;
            Bonus = 0;
        }
        // When a Method Uses Other method in Different Class Thats Calls Uses Relationship 
        //It is a a part Of Association
        public double GetSalaryWithBonus()
        {
            Calculator aCalculator = new Calculator();
            return aCalculator.Add(BasicSalary,Bonus);
        }
    }
}
