using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int highestNumber = int.MinValue;
        List<int> result = new List<int>();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (input[i] > highestNumber)
            {
                highestNumber = input[i];
                result.Add(highestNumber);
            }   
        }
        result.Reverse();
        Console.WriteLine(string.Join(" ", result));
    }
}