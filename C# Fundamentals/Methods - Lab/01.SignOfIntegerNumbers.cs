using System;

class Program
{
    static void Main(string[] args)
    {
        NumberCheck(int.Parse(Console.ReadLine()));
    }
    public static void NumberCheck(int number)
    {
        if (number < 0)
        {
            Console.WriteLine($"The number {number} is negative.");
        }
        else if (number > 0)
        {
            Console.WriteLine($"The number {number} is positive.");
        }
        else
        {
            Console.WriteLine($"The number {number} is zero.");
        }
    }
}