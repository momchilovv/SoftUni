using System;

namespace _02.SignOfIntegerNumber
{
    class Program
    {
        static void PrintSignOfInteger()
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 0)
            {
                Console.WriteLine($"The number {input} is negative.");
            }
            else if (input > 0)
            {
                Console.WriteLine($"The number {input} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {input} is zero.");
            }
        }
        static void Main(string[] args)
        {
            PrintSignOfInteger();
        }
    }
}