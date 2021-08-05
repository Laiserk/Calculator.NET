using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    class RPN : ICalculator
    {
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
        public double Compute()
        {
            return 0;
        }
        public string Pars(string expression)
        {
            return null;
        }
    }
}
