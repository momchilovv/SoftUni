using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> digits = new List<int>();
        int number = int.Parse(Console.ReadLine());
        int num = number;
        int factorial = 1;
        int sum = 0;

        while (num > 0)
        {
            digits.Add(num % 10);
            num = num / 10;
        }
        digits.Reverse();

        foreach (var digit in digits.ToArray())
        {
            for (int i = 1; i <= digit; i++)
            {
                factorial *= i;
            }
            sum += factorial;
            factorial = 1;
        }
        if (number == sum)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}