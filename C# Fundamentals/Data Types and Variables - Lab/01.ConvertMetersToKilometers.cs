using System;

class Program
{
    static void Main(string[] args)
    {
        int meters = int.Parse(Console.ReadLine());

        decimal kilometers = (decimal)meters;

        Console.WriteLine($"{kilometers / 1000:f2}");
    }
}