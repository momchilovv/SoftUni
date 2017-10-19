using System;

namespace _13.VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n;
            bool isVowel = "aeiouAEIOU".IndexOf(input.ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0;
            bool isDigit = int.TryParse(input, out n);

            if (isVowel)
            {
                Console.WriteLine("vowel");
            }
            else if (isDigit)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}