using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split().ToArray();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (dict.ContainsKey(word))
                    dict[word]++;

                else
                    dict[word] = 1;
            }
            List<string> result = new List<string>();

            foreach (var pair in dict)
            {
                if (pair.Value % 2 == 1)
                    result.Add(pair.Key);
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}