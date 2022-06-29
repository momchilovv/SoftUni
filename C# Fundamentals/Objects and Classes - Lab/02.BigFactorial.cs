using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        BigInteger factorial = 1;
        int number = int.Parse(Console.ReadLine());

        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}