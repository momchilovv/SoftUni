using System;
using System.Linq;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = numbers.Length / 4;
            int[] row1 = new int[2 * k];
            int[] row2 = new int[2 * k];

            for (int i = 0; i < k; i++)
            {
                row1[i] = numbers[k - i - 1];
                row1[row1.Length - i - 1] = numbers[numbers.Length - k + i];
                row2[2 * i] = numbers[2 * i + k];
                row2[2 * i + 1] = numbers[2 * i + k + 1];
            }

            int[] result = new int[k * 2];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = row1[i] + row2[i];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}