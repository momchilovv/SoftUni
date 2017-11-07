using System;
using System.Linq;

namespace _03.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = numbers.Length / 4;
            var leftRow = numbers.Take(k).Reverse();
            var rightRow = numbers.Reverse().Take(k);
            var firstRow = leftRow.Concat(rightRow).ToArray();
            var secondRow = numbers.Skip(k).Take(2 * k).ToArray();
            var sum = firstRow.Select((x, index) => x + secondRow[index]);

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}