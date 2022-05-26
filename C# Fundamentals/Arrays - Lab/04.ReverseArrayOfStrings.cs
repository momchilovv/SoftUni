using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();

        foreach (var item in input.OrderByDescending(x => x))
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}