using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NET
{
    public interface IOperetions
    {
        double UnaryMinus(double x);
        double Sum(double x, double y);
        double Difference(double x, double y);
        double Multiplication(double x, double y);
        double Division(double x, double y);
    }
}
