using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isBalanced = true;

            foreach (var ch in input)
            {
                switch (ch)
                {
                    case '(':
                    case '{':
                    case '[':
                        stack.Push(ch);
                        break;
                    case ')':
                        if (!stack.Any() || stack.Pop() != '(')
                        {
                            isBalanced = false;
                        }
                        break;
                    case '}':
                        if (!stack.Any() || stack.Pop() != '{')
                        {
                            isBalanced = false;
                        }
                        break;
                    case ']':
                        if (!stack.Any() || stack.Pop() != '[')
                        {
                            isBalanced = false;
                        }
                        break;
                }
            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else Console.WriteLine("NO");
        }
    }
}