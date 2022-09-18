using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var stack = new Stack<int>();

        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int s = input[1];
        int x = input[2];

        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < n; i++)
        {
            stack.Push(numbers[i]);
        }

        for (int i = 0; i < s; i++)
        {
            stack.Pop();
        }

        if (stack.Count == 0)
        {
            Console.WriteLine("0");
            return;
        }

        if (stack.Contains(x))
        {
            Console.WriteLine(true.ToString().ToLower());
        }

        else
        {
            Console.WriteLine(stack.Min());
        }
    }
}