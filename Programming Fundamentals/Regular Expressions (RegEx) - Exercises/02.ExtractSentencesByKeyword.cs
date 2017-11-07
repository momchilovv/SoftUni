using System;
using System.Text.RegularExpressions;

namespace _02.ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string input = Console.ReadLine();
            string pattern = $@"\b {keyword} \b";

            foreach (Match sentence in Regex.Matches(input, pattern))
            {
                Console.WriteLine(sentence);
            }
        }
    }
}