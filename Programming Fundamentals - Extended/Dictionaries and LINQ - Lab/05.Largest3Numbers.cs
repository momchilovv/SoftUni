using System;
using System.Linq;

namespace _05.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x).Take(3)));
        }
    }
}