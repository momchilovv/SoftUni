﻿using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .OrderByDescending(x => x)
            .Take(3)
            .ToArray();

        Console.WriteLine(string.Join(" ", input));
    }
}