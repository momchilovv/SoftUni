using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var stack = new Stack<int>();

        var queries = int.Parse(Console.ReadLine());

        for (int i = 0; i < queries; i++)
        {
            var command = Console.ReadLine().Split();

            if (command[0] == "1")
            {
                stack.Push(int.Parse(command[1]));
            }

            if (stack.Count > 0)
            {
                if (command[0] == "2")
                {
                    stack.Pop();
                }

                if (command[0] == "3")
                {
                    Console.WriteLine(stack.Max());
                }

                if (command[0] == "4")
                {
                    Console.WriteLine(stack.Min());
                }
            } 
        }

        Console.WriteLine(String.Join(", ", stack));
    }
}