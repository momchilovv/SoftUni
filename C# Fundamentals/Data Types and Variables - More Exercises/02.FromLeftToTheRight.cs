using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int numbers = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < numbers; i++)
        {
            string[] input = Console.ReadLine().Split();
            long firstNumber = long.Parse(input[0]);
            long secondNumber = long.Parse(input[1]);

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(SumOfDigits(firstNumber));
            }
            else
            {
                Console.WriteLine(SumOfDigits(secondNumber));
            }
        }
    }
    public static int SumOfDigits(long number)
    {
        int sum = 0;

        while (number != 0)
        {
            sum += (int)(number % 10);
            number /= 10;
        }

        return Math.Abs(sum);
    }
}