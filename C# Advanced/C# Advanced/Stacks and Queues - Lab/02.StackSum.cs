using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var stack = new Stack<int>();

        var input = Console.ReadLine().Split().Select(int.Parse);

        foreach (var item in input)
        {
            stack.Push(item);
        }

        var command = Console.ReadLine().Split();

        while (command[0].ToLower() != "end")
        {
            if (command[0].ToLower() == "add")
            {
                for (int i = 1; i < command.Length; i++)
                {
                    stack.Push(int.Parse(command[i]));
                }
            }
            if (command[0].ToLower() == "remove")
            {
                if (stack.Count >= int.Parse(command[1]))
                {
                    for (int i = 0; i < int.Parse(command[1]); i++)
                    {
                        stack.Pop();
                    }
                }             
            }

            command = Console.ReadLine().Split();
        }

        Console.WriteLine($"Sum: {stack.Sum()}");
    }
}