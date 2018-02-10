using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string[]> sentence = () => Console.ReadLine().Split(new[] {" " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Action<List<string>> uppercase = word => Console.WriteLine(string.Join("\r\n", word));

            List<string> uppercases = new List<string>();
            var input = sentence();
            foreach (var word in input)
            {
                
                if (Char.IsUpper(word, 0))
                {
                    uppercases.Add(word);
                }
            }
            uppercase(uppercases);
        }
    }
}