using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double Result { get; set; }
        public double Add(double firstNumber,double secondNumber)
        {
            Result = firstNumber + secondNumber;
            return Result;
        }
        public double Subtract(double firstNumber, double secondNumber)
        {
            Result = firstNumber - secondNumber;
            return Result;
        }
        public double Multiply(double firstNumber, double secondNumber)
        {
            Result = firstNumber*secondNumber;
            return Result;
        }
        public double Division(double firstNumber, double secondNumber)
        {
            Result = firstNumber/secondNumber;
            return Result;
        }

    }
}
