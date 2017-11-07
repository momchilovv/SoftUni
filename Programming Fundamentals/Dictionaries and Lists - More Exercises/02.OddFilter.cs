using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> originalOdd = new List<int>();
            List<int> results = new List<int>();

            foreach (var num in integers)
            {
                if (num % 2 == 0)
                {
                    originalOdd.Add(num);
                }
            }
            foreach (var num in originalOdd)
            {
                if (num > originalOdd.Average())
                {
                    results.Add(num + 1);
                }
                else
                {
                    results.Add(num - 1);
                }
            }
            Console.WriteLine(string.Join(" ", results));
        }
    }
}