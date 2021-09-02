using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NET
{
    public class DifferenceOperation : Operation
    {
        double number1, number2;

        public DifferenceOperation(double number1, double number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
        public override void ExecuteOperation()
        {
            Result = number1 - number2;
        }

        public override string ToString()
        {
            return $"Difference of {number1} and {number2}";
        }
    }
}
