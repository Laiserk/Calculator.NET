using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class Calculator
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
        static void Main(string[] args)
        {
            while (true)
            {
                string expression = Console.ReadLine();
                //var rpn = new RPN();
                //expression = rpn.Pars(expression);
                //var calc = new Calculator();
                //Console.WriteLine(calc.Сompute(expression));
            }
        }
    }
}
