using System;

namespace _02.ReverseAnArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}