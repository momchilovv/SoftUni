using System;

namespace _02.CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string substring = Console.ReadLine().ToLower();
            int count = 0;

            for (int i = 0; i <= input.Length - substring.Length; i++)
            {
                if (input.Substring(i, substring.Length).ToLower().Equals(substring.ToLower()))                
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}