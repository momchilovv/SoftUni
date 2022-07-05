using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> appereances = new Dictionary<string, int>();
        List<string> oddOccurences = new List<string>();

        string[] input = Console.ReadLine().Split();

        foreach (var item in input)
        {
            if (!appereances.ContainsKey(item))
            {
                appereances.Add(item, 1);
            }
            else
            {
                appereances[item]++;
            }
        }

        foreach (var item in appereances.Where(i => i.Value % 2 == 1))
        {
            if (!oddOccurences.Contains(item.Key.ToLower()))
            {
                oddOccurences.Add(item.Key.ToLower());
            }
        }

        Console.WriteLine(string.Join(" ", oddOccurences));
    }
}