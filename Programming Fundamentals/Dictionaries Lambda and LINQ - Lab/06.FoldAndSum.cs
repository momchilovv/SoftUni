using System;
using System.Linq;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = input.Length / 4;

            int[] row1Left = input.Take(k).Reverse().ToArray();
            int[] row1Right = input.Reverse().Take(k).ToArray();
            int[] row1 = row1Left.Concat(row1Right).ToArray();
            int[] row2 = input.Skip(k).Take(2 * k).ToArray();

            var sum = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}