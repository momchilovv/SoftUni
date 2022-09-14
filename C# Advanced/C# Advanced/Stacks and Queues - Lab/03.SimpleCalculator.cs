using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var stack = new Stack<string>();

        var input = Console.ReadLine().Split();

        var sum = int.Parse(input[0]);

        foreach (var item in input.Reverse())
        {
            stack.Push(item);
        }

        while (stack.Count > 0)
        {
            var pop = stack.Pop();

            if (pop == "+")
            {
                sum += int.Parse(stack.Pop());
            }
            if (pop == "-")
            {
                sum -= int.Parse(stack.Pop());
            }
        }

        Console.WriteLine(sum);
    }
}