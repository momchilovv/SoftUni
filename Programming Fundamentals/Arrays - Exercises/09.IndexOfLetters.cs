using System;

namespace _09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().ToLower().ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {word[i] - 'a'}");
            }         
        }
    }
}