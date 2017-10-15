using System;

namespace _12.EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int previousPair = 0;
            int currentPair = 0;
            int diff = 0;
            int maxdiff = 0;

            for (int i = 0; i < n; i++)
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                if (i == 0)
                    previousPair = firstNumber + secondNumber;
                else
                {
                    currentPair = firstNumber + secondNumber;
                    diff = Math.Abs(currentPair - previousPair);
                    if (diff > maxdiff)
                    {
                        maxdiff = diff;
                    }
                    previousPair = currentPair;
                }
                if (maxdiff == 0)
                    Console.WriteLine($"Yes, value = {previousPair}");
                else
                    Console.WriteLine($"No, maxdiff = {maxdiff}");
            }
        }
    }
}