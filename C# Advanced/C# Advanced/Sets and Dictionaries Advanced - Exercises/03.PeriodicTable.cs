using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var periodicTable = new HashSet<string>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            foreach (var item in input)
            {
                periodicTable.Add(item);
            }
        }

        Console.WriteLine(string.Join(" ", periodicTable.OrderBy(x => x)));
    }
}