using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int primeSum = 0, nonPrimeSum = 0;

        while (input != "stop")
        {
            int number = int.Parse(input);

            if (number < 0)
            {
                Console.WriteLine("Number is negative.");
            }
            else if (IsPrime(number))
            {
                primeSum += number;
            }
            else
            {
                nonPrimeSum += number;
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
        Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
    }
    public static bool IsPrime (int number)
    {
        int n;
        for (n = 2; n <= number - 1; n++)
        {
            if (number % n == 0)
            {
                return false;
            }
        }
        if (number == n)
        {
            return true;
        }
        return false;
    } 
}