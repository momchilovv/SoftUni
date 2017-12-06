using System;
using System.Linq;

namespace _04.TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];
                    if (arr.Contains(sum))
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {sum}");
                        count++;
                    }
                }
            }
            if (count == 0)
                Console.WriteLine("No");
        }
    }
}