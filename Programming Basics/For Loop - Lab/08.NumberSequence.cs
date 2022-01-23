using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<double> numbers = new List<double>();

        for (int i = 0; i < n; i++)
        {
            numbers.Add(double.Parse(Console.ReadLine()));
        }
        Console.WriteLine($"Max number: {numbers.Max()}");
        Console.WriteLine($"Min number: {numbers.Min()}");
    }
}