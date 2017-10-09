using System;
using System.Linq;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rotate = int.Parse(Console.ReadLine());

            int[] sumResult = new int[data.Length];

            for (int i = 0; i < rotate; i++)
            {
                int lastElement = data[data.Length - 1];

                for (int j = data.Length - 1; j > 0; j--)
                {
                    data[j] = data[j - 1];
                }

                data[0] = lastElement;

                for (int k = 0; k < data.Length; k++)
                {
                    sumResult[k] += data[k];
                }
            }
            Console.WriteLine(string.Join(" ", sumResult));
        }
    }
}