using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<int> topNumbers = new List<int>();

        foreach (var number in array)
        {
            if (number > array.Average())
            {
                topNumbers.Add(number);
            }
        }
        if (topNumbers.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            topNumbers.Sort();
            topNumbers.Reverse();
            Console.WriteLine(string.Join(" ", topNumbers.Take(5)));
        }
    }
}