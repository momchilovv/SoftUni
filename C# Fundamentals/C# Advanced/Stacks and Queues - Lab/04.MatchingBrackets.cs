using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stackOpenBracket = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stackOpenBracket.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIndex = stackOpenBracket.Pop();
                    string contents = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(contents);
                }
            }
        }
    }
}