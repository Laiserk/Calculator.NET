using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NET
{
    abstract public class Operation : IOperation
    {
        public double Result { get; protected set; }

        public OperationState state { get; protected set; }

        abstract public void ExecuteOperation();
    }
}