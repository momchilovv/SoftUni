using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        long n = int.Parse(Console.ReadLine());

        var dividers = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> result = new List<int>();

        List<Predicate<int>> predicates = new List<Predicate<int>>(dividers.Count);

        foreach (var divider in dividers)
        {
            predicates.Add(n => n % divider == 0);
        }

        for (int i = 1; i <= n; i++)
        {
            bool isDivisible = true;

            foreach (var predicate in predicates)
            {
                if (!predicate(i))
                {
                    isDivisible = false;
                }
            }
            if (isDivisible)
            {
                result.Add(i);
            }
        }

        Console.WriteLine(String.Join(" ", result));
    }
}