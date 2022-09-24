using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        double[] values = Console.ReadLine().Split().Select(double.Parse).ToArray();

        var dict = new Dictionary<double, int>();

        foreach (var value in values)
        {
            if (!dict.ContainsKey(value))
            {
                dict.Add(value, 1);
            }
            else
            {
                dict[value]++;
            }
        }

        foreach (var value in dict)
        {
            Console.WriteLine($"{value.Key} - {value.Value} times");
        }
    }
}