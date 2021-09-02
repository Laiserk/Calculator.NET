using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NET.Command
{
    public class Processor
    {
        public IOperation operation;

        public void SetOperation(IOperation operation)
        {
            this.operation = operation;
        }
        public void Run()
        {
            operation.ExecuteOperation();
        }
    }
}
