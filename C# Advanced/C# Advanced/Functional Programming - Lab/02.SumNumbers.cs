﻿using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        Console.WriteLine(numbers.Length);
        Console.WriteLine(numbers.Sum());
    }
}