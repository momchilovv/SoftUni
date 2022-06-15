using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> mergedList = new List<int>();

        int longest = Math.Max(firstList.Count, secondList.Count);

        for (int i = 0; i < longest; i++)
        {
            if (firstList.Count > i)
            {
                mergedList.Add(firstList[i]);
            }
            if (secondList.Count > i)
            {
                mergedList.Add(secondList[i]);
            }
        }
        Console.WriteLine(string.Join(" ", mergedList));
    }
}