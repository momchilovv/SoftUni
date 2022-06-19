using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split("|").Select(s => string.Join(" ", s.Split(" ", StringSplitOptions.RemoveEmptyEntries))).Where(s => !string.IsNullOrWhiteSpace(s)).Reverse().ToArray();

        Console.WriteLine(string.Join(" ", input));
    }
}