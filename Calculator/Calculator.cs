using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        static void Main(string[] args)
        {

        }

        public double Add(double a, double b)
        {
            return a + b; 
        }
        double Subtract(double a, double b)
        {
            return a - b;
        }
        double Multiply(double a, double b)
        {
            return a * b;
        }
        double Power(double a, double exp)
        {
            return Math.Pow(a,exp);
        }

    }
}
