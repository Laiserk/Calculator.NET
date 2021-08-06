using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public interface ICalculator
    {
        double Sum(double x, double y);
        double Difference(double x, double y);
        double Multiplication(double x, double y);
        double Division(double x, double y);
        double Compute(string input);
    }


}
