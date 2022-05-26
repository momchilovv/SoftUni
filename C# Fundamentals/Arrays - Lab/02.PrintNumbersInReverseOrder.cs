using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int[] numbers = new int[number];

        for (int i = 0; i < number; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        foreach (var num in numbers.Reverse())
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
}