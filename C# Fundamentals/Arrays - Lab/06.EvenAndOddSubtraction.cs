using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int sumEven = 0, sumOdd = 0;

        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                sumEven += number;
            }
            else
            {
                sumOdd += number;
            }
        }
        Console.WriteLine(sumEven - sumOdd);
    }
}