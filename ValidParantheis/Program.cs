using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParantheis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidParanthesis("()[]{}"));
            Console.ReadLine();
        }
        private static Boolean ValidParanthesis(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var ch in s)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else
                {
                    if (stack.Count() != 0 && IsPairParanthesis(stack.Peek(), ch))
                    {
                        stack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return (stack.Count() == 0);
        }
        private static Boolean IsPairParanthesis(char left, char right)
        {
            return (left == '(' && right == ')' || left == '[' && right == ']' || left == '{' && right == '}') ;
        }
    }
}
