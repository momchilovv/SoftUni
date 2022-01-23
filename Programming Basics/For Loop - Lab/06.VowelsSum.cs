using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int sum = 0;

        Dictionary<char, int> vowels = new Dictionary<char, int>()
        {
            { 'a', 1 },
            { 'e', 2 },
            { 'i', 3 },
            { 'o', 4 },
            { 'u', 5 }
        };
        foreach (var letter in input)
        {
            foreach (var vowel in vowels)
            {
                if (letter == vowel.Key)
                {
                    sum += vowel.Value;
                }
            }
        }
        Console.WriteLine(sum);
    }
}