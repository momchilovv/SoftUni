using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[]> numbers = () => Console.ReadLine().Split().Select(int.Parse).ToArray();

            Action<int> smallestNumber = number => Console.WriteLine(number);

            var input = numbers();
            smallestNumber(input.Min());
        }
    }
}