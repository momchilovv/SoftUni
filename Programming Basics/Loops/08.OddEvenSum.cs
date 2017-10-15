using System;

namespace _08.OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                if (i % 2 == 0) oddSum += element;
                else evenSum += element;
            }
            if (oddSum == evenSum)
                Console.WriteLine($"Yes, sum = {oddSum}");
            else
                Console.WriteLine($"No, diff = {Math.Abs(oddSum - evenSum)}");
        }
    }
}