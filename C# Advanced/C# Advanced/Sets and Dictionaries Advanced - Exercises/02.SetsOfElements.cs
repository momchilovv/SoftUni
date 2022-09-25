using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var firstSet = new HashSet<int>();
        var secondSet = new HashSet<int>();

        for (int i = 0; i < input[0]; i++)
        {
            firstSet.Add(int.Parse(Console.ReadLine()));
        }

        for (int i = 0; i < input[1]; i++)
        {
            secondSet.Add(int.Parse(Console.ReadLine()));
        }

        foreach (var element in firstSet)
        {
            if (secondSet.Contains(element))
            {
                Console.Write($"{element} ");
            }
        }
    }
}