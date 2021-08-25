using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NET
{
    public class ParsRPN : IPars
    {

        public bool IsDelimeter(char c)
        {
            if ((" =".IndexOf(c) != -1))
                return true;
            return false;
        }
        public bool IsOperator(char с)
        {
            if (("+-/*^()#".IndexOf(с) != -1))
                return true;
            return false;
        }
        static private byte GetPriority(char s)
        {
            switch (s)
            {
                case '(':
                case ')': return 0;
                case '+':
                case '-': return 1;
                case '*':
                case '/': return 2;
                case '#': return 3;
                default: return 4;
            }
        }
        public string Pars(string input)
        {
            string output = string.Empty; 
            var operStack = new Stack<char>(); 

            for (int i = 0; i < input.Length; i++) 
            {
                
                if (IsDelimeter(input[i]))
                    continue; 
                
                if (Char.IsDigit(input[i])) 
                {
                    
                    while (!IsDelimeter(input[i]) && !IsOperator(input[i]))
                    {
                        output += input[i]; 
                        i++; 

                        if (i == input.Length) break; 
                    }
                    output += " ";
                    i--; 
                }    
                if (IsOperator(input[i])) 
                {
                    if (input[i] == '(') 
                        operStack.Push(input[i]); 
                    else if (input[i] == ')') 
                    {
                        char s = operStack.Pop();

                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = operStack.Pop();
                        }
                    }
                    else 
                    {
                        if (operStack.Count > 0)
                        {
                            if (GetPriority(input[i]) <= GetPriority(operStack.Peek()))
                                output += operStack.Pop().ToString() + " ";
                        }
                        if (i > 0)
                        {
                            if (input[i] == '-' && (IsOperator(input[i - 1]) && input[i - 1] != ')'))
                            {
                                operStack.Push('#');
                                continue;
                            }
                        }
                        else
                        {
                            if (input[i] == '-' && i == 0 )
                            {
                                operStack.Push('#');
                                continue;
                            }
                        }
                        
                        operStack.Push(char.Parse(input[i].ToString())); 

                    }
                }
            }

            while (operStack.Count > 0)
                output += operStack.Pop() + " ";

            return output; 
        }
    }
}
