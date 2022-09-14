using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        var stack = new Stack<int>();

        var input = Console.ReadLine();

        var newString = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                stack.Push(i);
            }

            if (input[i] == ')')
            {
                var index = stack.Pop();

                newString.AppendLine(input.Substring(index, i - index + 1));
            }
        }
        Console.WriteLine(newString.ToString().Trim());
    }
}