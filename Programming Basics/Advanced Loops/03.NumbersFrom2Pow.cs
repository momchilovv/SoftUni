using System;

namespace _03.NumbersFrom2Pow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            Console.WriteLine(num);
            for (int i = 1; i <= n; i++)
            {
                num *= 2;
                Console.WriteLine(num);
            }
        }
    }
}