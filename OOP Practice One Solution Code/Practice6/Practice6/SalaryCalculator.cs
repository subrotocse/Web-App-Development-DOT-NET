using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice6
{
    class SalaryCalculator
    {

        double totalSalary;
        public string  EmployeeName { get; set; }
        public double BasicAmount { get; set; }
        public double HouseRent { get; set; }
        public double MedicalAllowance{ get; set; }
        public string GetAllInformation()
        {
            string employee = "Your  Total Salary Is :" + totalSalary;
            return employee;
        }
        public double GetTotalSalary(double houseRentPersentage,double medicalAllowancePercentage)
        {          
            HouseRent = houseRentPersentage * 100 / BasicAmount;
            MedicalAllowance = medicalAllowancePercentage * 100 / BasicAmount;
        totalSalary = BasicAmount + HouseRent + MedicalAllowance;
            return totalSalary;
        }
       
    }
}
