using System;

namespace _07.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstEntry = Console.ReadLine();
            var secondEntry = Console.ReadLine();
            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstEntry}");
            Console.WriteLine($"b = {secondEntry}");
            Console.WriteLine("After:");
            Console.WriteLine($"a = {secondEntry}");
            Console.WriteLine($"b = {firstEntry}");
        }
    }
}