using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NET
{
    public enum OperationState
    {
        Unprocessed,
        Failed,
        Succeed
    }
    public interface IOperation
    {
        void ExecuteOperation();
        double Result { get; }

        OperationState state { get; }
    }
}
