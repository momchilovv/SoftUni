using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double oddSum = 0;
        double evenSum = 0;

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                evenSum += double.Parse(Console.ReadLine());
            }
            else
            {
                oddSum += double.Parse(Console.ReadLine());
            }
        }
        if (evenSum == oddSum)
        {
            Console.WriteLine($"Yes\r\nSum = {evenSum}");
        }
        else
        {
            Console.WriteLine($"No\r\nDiff = {Math.Abs(evenSum - oddSum)}");
        }
    }
}