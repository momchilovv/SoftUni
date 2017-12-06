using System;
using System.Linq;

namespace _05.RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var number in arr)
            {
                Console.WriteLine($"{number} => {Math.Round(number, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}