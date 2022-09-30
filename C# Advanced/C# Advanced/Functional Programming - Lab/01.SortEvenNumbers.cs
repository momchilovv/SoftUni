using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).Where(i => i % 2 == 0).OrderBy(i => i).ToArray();

        Console.WriteLine(String.Join(", ", numbers));
    }
}