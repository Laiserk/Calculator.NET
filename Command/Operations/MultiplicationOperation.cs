using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NET
{
    public class MultiplicationOperation : Operation
    {
        double number1, number2;

        public MultiplicationOperation(double number1, double number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
        public override void ExecuteOperation()
        {
            Result = number1 * number2;
            state = OperationState.Succeed;
        }

        public override string ToString()
        {
            return $"Multiplication of {number1} and {number2}";
        }
    }
}
