using System;

namespace _01.HelloName
{
    class Program
    {
        static void PrintName()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
        static void Main(string[] args)
        {
            PrintName();
        }
    }
}