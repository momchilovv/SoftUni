using System;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(double.Parse).ToList();
            var result = nums.OrderByDescending(x => x).Take(3);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}