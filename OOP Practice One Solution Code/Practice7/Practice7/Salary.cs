using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7
{
    class Salary
    {
        public double Increase { get; set; }
        public int noOfIncrements = 0;
        public double Basic { get; set; }
        public double Medical { get; set; }
        public double Conveyance { get; set; }
        public double Total { get; set; }
        public double GetBasic()
        {
            Basic += Increase;
            return Basic;
        }
        public double GetTotal()
        {
            return Basic + Medical + Conveyance;
        }
        public double GetMedicalAllowance(double medicalPercentage)
        {
            Medical=medicalPercentage*Basic/100;
            return Medical;
        }
        public double GetConveyance(double conveyancePercentage)
        {
            Conveyance= conveyancePercentage*Basic/100;
            return Conveyance;
        }
        public double GetIncreaseAmount(double increment)
        {
            Increase =  (increment * Basic / 100);
            noOfIncrements += 1;
            return Increase;
        }
    }
}
