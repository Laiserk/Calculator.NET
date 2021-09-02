using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter expression");

                string expression = Console.ReadLine();
                IPars pars = new ParsRPN();
                Console.WriteLine(pars.Pars(expression));

                expression = pars.Pars(expression);
                ICompute comp = new ComputeRPN();

                Console.WriteLine(comp.Compute(expression));

            }
        }
    }
}
