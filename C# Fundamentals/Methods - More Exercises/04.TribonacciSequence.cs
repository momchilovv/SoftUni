using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        CalculateSequence(number);
    }
    public static void CalculateSequence(BigInteger number)
    {
        BigInteger first = 1, second = 1, third = 2, sum = first + second + third;
        if (number == 1)
        {
            Console.WriteLine(1);
        }
        else if (number == 2)
        {
            Console.WriteLine("1 1");
        }
        else
        {
            Console.Write("1 1 2 ");
        }
        
        for (int i = 4; i <= number; i++)
        {
            Console.Write($"{sum} ");
            first = second;
            second = third;
            third = sum;
            sum = first + second + third;
        }
        Console.WriteLine();
    }
}