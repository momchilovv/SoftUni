using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();

            MatchCollection matched = Regex.Matches(input, pattern);

            foreach(Match name in matched)
            {
                Console.WriteLine(name);
            }
        }
    }
}