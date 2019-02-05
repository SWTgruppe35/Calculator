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
            Accumulator = a + b;
            return Accumulator; 
        }
        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }
        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }
        public double Power(double a, double exp)
        {
            Accumulator = Math.Pow(a, exp);
            return Accumulator;
        }

        public double Divide(double divided, double divisor)
        {
            if (divisor == 0)
                throw new System.DivideByZeroException();
            Accumulator = divided / divisor;
            return Accumulator;

        }
        
        public double Accumulator { get ; private set; }


    }
}
