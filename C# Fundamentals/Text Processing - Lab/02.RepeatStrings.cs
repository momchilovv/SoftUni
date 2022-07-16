using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();

        foreach (var word in input)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.Write($"{word}");
            }
        }
    }
}