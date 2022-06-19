using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int[] detonation = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int bombNumber = detonation[0], power = detonation[1], startIndex, endIndex;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == bombNumber)
            {
                startIndex = i - power;
                endIndex = i + power + 1;

                if (startIndex < 0)
                {
                    startIndex = 0;
                }
                if (endIndex > numbers.Count)
                {
                    endIndex = numbers.Count;
                }
                for (int j = startIndex; j < endIndex; j++)
                {
                    numbers[j] = 0;
                }
            }
        }
        Console.WriteLine(numbers.Sum());
    }
}