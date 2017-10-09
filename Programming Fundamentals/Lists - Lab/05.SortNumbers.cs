using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            var sorted = new List<double>();

            foreach (var item in input)
            {
                sorted.Add(item);
            }
            sorted.Sort();
            Console.WriteLine(string.Join(" <= ", sorted));
        }
    }
}