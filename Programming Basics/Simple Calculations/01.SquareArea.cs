using System;

namespace _01.SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Square = {a*a}");
        }
    }
}