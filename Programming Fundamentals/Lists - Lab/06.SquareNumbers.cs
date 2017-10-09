using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var squares = new List<int>();
            foreach (var item in input)
            {
                if (Math.Sqrt(item) == (int)Math.Sqrt(item))
                {
                    squares.Add(item);
                }
            }
            squares.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", squares));
        }
    }
}