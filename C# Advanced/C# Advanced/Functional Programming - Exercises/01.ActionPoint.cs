using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        Action<string[]> printNames = names => Console.WriteLine(string.Join(Environment.NewLine, names));

        string[] input = Console.ReadLine().Split();

        printNames(input);
    }
}