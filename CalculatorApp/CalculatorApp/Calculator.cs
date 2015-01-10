using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorApp
{
    public class Calculator
    {
        public double Result { set; get; }

        public double ADD(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public double Divide(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}