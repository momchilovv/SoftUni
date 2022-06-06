using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Console.WriteLine(MultiplyEvensToOdds(GetEvensSum(input), GetOddsSum(input)));
    }
    public static int GetEvensSum(string input)
    {
        int evenSum = 0;

        foreach (var digit in input)
        {
            if (char.GetNumericValue(digit) % 2 == 0)
            {
                evenSum += (int)char.GetNumericValue(digit);
            }
        }
        return Math.Abs(evenSum);
    }
    public static int GetOddsSum(string input)
    {
        int oddSum = 0;

        foreach (var digit in input)
        {
            if (char.GetNumericValue(digit) % 2 == 1)
            {
                oddSum += (int)char.GetNumericValue(digit);
            }
        }
        return Math.Abs(oddSum);
    }
    public static int MultiplyEvensToOdds(int evenSum, int oddSum)
    {
        return evenSum * oddSum;
    } 
}