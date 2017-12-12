using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.LargestNElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int number = int.Parse(Console.ReadLine());

            foreach (var num in input)
            {
                list.Add(num);
            }

            list.OrderByDescending(n => n);

            var result = list.OrderByDescending(x => x).Take(number);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}