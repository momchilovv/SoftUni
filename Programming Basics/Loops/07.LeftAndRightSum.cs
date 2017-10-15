using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var firstPair = new List<int>();
            var secondPair = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                firstPair.Add(num);
            }
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                secondPair.Add(num);
            }
            if (firstPair.Sum() == secondPair.Sum())
                Console.WriteLine($"Yes, sum = {firstPair.Sum()}");
            else
                Console.WriteLine($"No, diff = {Math.Abs(firstPair.Sum() - secondPair.Sum())}");
        }
    }
}