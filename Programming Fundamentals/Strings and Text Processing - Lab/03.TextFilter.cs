using System;

namespace _03.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string bannedWords = Console.ReadLine();
            string[] input = bannedWords.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            bannedWords = Console.ReadLine();
            string output = bannedWords;

            for (int i = 0; i < input.Length; i++)
            {
                output = output.Replace(input[i], new string('*', input[i].Length));
            }
            Console.WriteLine(output);
        }
    }
}