using System;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    class Program
    {
        public static void Main()
        {
            string pattern = @"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,20}";
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine($"{m}");
            }
        }
    }
}