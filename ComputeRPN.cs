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
        private IOperetions operetions;

        public double Compute(string input)
        {
            double result = 0;
            var temp = new Stack<double>();
            operetions = new OperetionRPN();

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
                        result = operetions.UnaryMinus(a);
                        temp.Push(result);

                    }
                    else
                    {
                        double a = temp.Pop();
                        double b = temp.Pop();

                        switch (input[i])
                        {
                            case '+': result = operetions.Sum(b, a); break;
                            case '-': result = operetions.Difference(b, a); break;
                            case '*': result = operetions.Multiplication(b, a); break;
                            case '/': result = operetions.Division(b, a); break;
                        }
                        temp.Push(result);
                    }
                }
            }
            return temp.Peek();
        }
    }
}
