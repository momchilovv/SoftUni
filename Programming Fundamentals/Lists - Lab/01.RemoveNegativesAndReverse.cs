using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var list = new List<int>();

            foreach (var num in input)
            {
                if (num > 0)
                {
                    list.Add(num);
                }               
            }
            list.Reverse();
            if (list.Count == 0)
            {
                Console.Write("empty");
            }
            else
            {
                foreach (var num in list)
                {
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();
        }
    }
}