using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = new Dictionary<int, int>();
        
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            if (!numbers.ContainsKey(currentNumber))
            {
                numbers.Add(currentNumber, 1);
            }
            else
            {
                numbers[currentNumber]++;
            }
        }

        foreach (var number in numbers)
        {
            if (number.Value % 2 == 0)
            {
                Console.WriteLine(number.Key);
            }
        }
    }
}