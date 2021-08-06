using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter expression");
                var rpn = new RPN();
                string x = Console.ReadLine();
                Console.WriteLine(rpn.Pars(x));
                string y = rpn.Pars(x);
                Console.WriteLine(rpn.Compute(y));
                //Console.WriteLine(rpn.Compute(rpn.Pars(Console.ReadLine())));
            }
        }
    }
}
