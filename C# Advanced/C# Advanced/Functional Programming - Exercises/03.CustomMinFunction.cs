﻿using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        Func<int[], int> minNumber = x => x.Min();

        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine(minNumber(input));
    }
}