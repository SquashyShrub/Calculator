using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._1._2
{
    
    internal interface IOperations
    {
        double Add(double num1, double num2);
        double Subtract(double num1, double num2);
        double Multiply(double num1, double num2);
        double Divide(double num1, double num2);
        double Square(double num);
        double SqRoot(double num);
        double Fraction (double num);
    }

    internal class Operations : IOperations
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Divide(double num1, double num2)
        {
            return (num1 / num2);
        }
        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Percent(double num)
        {
            return num / 100;
        }
        public double SqRoot(double num)
        {
            return Math.Sqrt(num);
        }
        public double Square(double num)
        {
            return (num * num);
        }
        public double Fraction(double num)
        {
            return 1 / num;
        }
    }
}
