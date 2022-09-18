using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var rackCapacity = int.Parse(Console.ReadLine());

        var stack = new Stack<int>(input);

        var racksUsed = 1;
        var currentRackCapacity = 0;

        while (stack.Any())
        {
            if (stack.Peek() + currentRackCapacity <= rackCapacity)
            {
                currentRackCapacity += stack.Pop();
            }
            else
            {
                racksUsed++;
                currentRackCapacity = 0;
            }
        }
        Console.WriteLine(racksUsed);
    }
}