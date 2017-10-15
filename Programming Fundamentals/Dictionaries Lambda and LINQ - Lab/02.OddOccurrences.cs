using System;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var words = input.ToLower().Split();

            var dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (dict.ContainsKey(word))               
                    dict[word]++;             
                else
                    dict[word] = 1;
            }
            var list = new List<string>();

            foreach (var word in dict)
            {
                if (word.Value % 2 != 0)                
                    list.Add(word.Key);                              
            }
            Console.Write(string.Join(", ", list));
            Console.WriteLine();
        }
    }
}