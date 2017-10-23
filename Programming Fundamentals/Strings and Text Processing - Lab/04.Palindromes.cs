using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', '!', '?', '.', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> palidromes = new List<string>();

            foreach (var word in input)
            {
                if (IsPalindrome(word))
                    palidromes.Add(word);
            }
            palidromes = palidromes.Distinct().OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", palidromes));
        }
        static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {
                if (min > max)               
                    return true;
                
                char a = value[min];
                char b = value[max];
                if (a != b)
                    return false;
                min++;
                max--;
            }
        }
    }
}