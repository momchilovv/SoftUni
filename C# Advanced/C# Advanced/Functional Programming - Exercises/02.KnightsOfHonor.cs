using System;

internal class Program
{
    static void Main(string[] args)
    {
        Action<string[]> printNames = names => Console.WriteLine("Sir " + string.Join(Environment.NewLine + "Sir ", names));

        string[] input = Console.ReadLine().Split();

        printNames(input);
    }
}