using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int dnaLength = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        int[] result = new int[dnaLength];

        int dnaSum = 0, dnaCount = -1, dnaIndex = -1, dnaSample = 0, sample = 0;

        while (input != "Clone them!")
        {
            sample++;
            int[] splitted = input.Split("!").Select(int.Parse).ToArray();

            int currentCount = 0, currentIndex = 0, currentEndIndex = 0, currentSum = 0, count = 0;

            bool isBestDna = false;

            for (int i = 0; i < splitted.Length; i++)
            {
                if (splitted[i] != 1)
                {
                    count = 0;
                    continue;
                }

                count++;
                if (count > currentCount)
                {
                    currentCount = count;
                    currentEndIndex = i;
                }
            }

            currentIndex = currentEndIndex - currentCount + 1;
            currentSum = splitted.Sum();

            if (currentCount > dnaCount)
            {
                isBestDna = true;
            }
            else if (currentCount == dnaCount)
            {
                if (currentIndex < dnaIndex)
                {
                    isBestDna = true;
                }
                else if (currentIndex == dnaIndex)
                {
                    if (currentSum > dnaSum)
                    {
                        isBestDna = true;
                    }
                }
            }

            if (isBestDna)
            {
                result = splitted;
                dnaCount = currentCount;
                dnaIndex = currentIndex;
                dnaSum = currentSum;
                dnaSample = sample;
            }
            input = Console.ReadLine();
        }
        Console.WriteLine($"Best DNA sample {dnaSample} with sum: {dnaSum}.");
        Console.WriteLine(String.Join(" ", result));
    }
}