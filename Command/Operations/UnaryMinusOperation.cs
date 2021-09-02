using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NET
{
    public class UnaryMinusOperation : Operation
    {
        double number;

        public UnaryMinusOperation(double number)
        {
            this.number = number;
        }
        public override void ExecuteOperation()
        {
            Result = -number;
        }

        public override string ToString()
        {
            return $"Inversion of {number}";
        }
    }
}
