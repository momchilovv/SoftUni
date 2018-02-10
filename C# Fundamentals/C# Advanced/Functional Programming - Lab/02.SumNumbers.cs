using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[]> numbers = () => Console.ReadLine().Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Action<int, int> sum = (count, theSum) => Console.WriteLine(count +"\r\n" + theSum);

            var input = numbers();
            int numbersCount = input.Count();
            int getSum = input.Sum();

            sum(numbersCount, getSum);
        }
    }
}