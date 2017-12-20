using System;

namespace _07.GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int originalA = a;
            int originalB = b;

            while (b != 0)
            {
                int oldB = b;
                b = a % b;
                a = oldB;
            }
            Console.WriteLine($"{a}");
        }
    }
}