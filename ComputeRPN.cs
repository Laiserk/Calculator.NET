using Calculator.NET.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NET
{
    public class ComputeRPN : ICompute
    {
        private ParsRPN pars = new ParsRPN();
        public double Compute(string input)
        {
            double result = 0;
            var temp = new Stack<double>();

            var processor = new Processor();

            for (int i = 0; i < input.Length; i++)
            {
                if (pars.IsDelimeter(input[i]))
                    continue;

                if (Char.IsDigit(input[i]))
                {
                    string a = string.Empty;

                    while (!pars.IsDelimeter(input[i]) && !pars.IsOperator(input[i]))
                    {
                        a += input[i];
                        i++;
                        if (i == input.Length) break;
                    }
                    temp.Push(double.Parse(a));
                    i--;
                }
                else if (pars.IsOperator(input[i]))
                {
                    if (input[i] == '#')
                    {
                        double a = temp.Pop();
                        processor.SetOperation(new UnaryMinusOperation(a));
                        processor.Run();

                        temp.Push(processor.operation.Result);
                    }
                    else
                    {
                        double a = temp.Pop();
                        double b = temp.Pop();

                        switch (input[i])
                        {
                            case '+':
                                processor.SetOperation(new SumOperation(b, a));
                                processor.Run();
                                result = processor.operation.Result; break;
                            case '-':
                                processor.SetOperation(new DifferenceOperation(b, a));
                                processor.Run();
                                result = processor.operation.Result; break;
                            case '*':
                                processor.SetOperation(new MultiplicationOperation(b, a));
                                processor.Run();
                                result = processor.operation.Result; break;
                            case '/':
                                processor.SetOperation(new DivisionOperation(b, a));
                                processor.Run();
                                result = processor.operation.Result; break;
                        }
                        temp.Push(result);
                    }
                }
            }
            return temp.Peek();
        }
    }
}
