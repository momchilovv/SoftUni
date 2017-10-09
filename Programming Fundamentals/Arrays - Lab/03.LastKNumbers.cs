using System;

namespace _03.LastKNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var num = new long[n];
            num[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for (int j = i - k; j <= i - 1; j++)
                {
                    if (j >= 0)
                        sum += num[j];   
                }
                num[i] = sum;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{num[i]} ");
            }
            Console.WriteLine();
        }
    }
}