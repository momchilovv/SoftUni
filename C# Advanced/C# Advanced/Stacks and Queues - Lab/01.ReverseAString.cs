using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var stack = new Stack<string>();

        var input = Console.ReadLine();

        foreach (var item in input)
        {
            stack.Push(item.ToString());
        }

        while (stack.Count > 0)
        {
            Console.Write(stack.Pop());
        }
    }
}