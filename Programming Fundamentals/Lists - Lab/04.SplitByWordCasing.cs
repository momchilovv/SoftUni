using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            bool isLower = false;
            bool isUpper = false;
            bool isMixed = false;

            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();

            foreach (var word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        isUpper = true;
                    }
                    if (char.IsLower(word[i]))
                    {
                        isLower = true;
                    }
                    if (char.IsLower(word[i]) && char.IsUpper(word[i]))
                    {
                        isMixed = true;
                    }
                }
                if (isLower)
                {
                    lowerCase.Add(word);
                }
                
                else if (isUpper)
                {
                    upperCase.Add(word);
                }
                else if (isMixed)
                {
                    mixedCase.Add(word);
                }
                isLower = false;
                isUpper = false;
                isMixed = false;
            }

            Console.WriteLine("Lower-case: {0}", String.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", String.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", String.Join(", ", upperCase));
        }
    }
}