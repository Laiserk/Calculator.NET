using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NET
{
    public class OperetionRPN : IOperetions
    {
        public double UnaryMinus(double x)
        {
            return -x;
        }
        public double Sum(double x, double y)
        {
            return x + y;
        }
        public double Difference(double x, double y)
        {
            return x - y;
        }
        public double Multiplication(double x, double y)
        {
            return x * y;
        }
        public double Division(double x, double y)
        {
            return x / y;
        }
    }
}
