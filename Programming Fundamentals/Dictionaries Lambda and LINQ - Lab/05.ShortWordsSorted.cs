using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            char[] separators = { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            var words = input.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            var result = words.Where(x => x.Length < 5);

            var list = new List<string>();
            foreach (var w in result)
            {
                if (list.Contains(w))
                    continue;
                else
                    list.Add(w);                
            }
            Console.WriteLine(string.Join(", ", list.OrderBy(x => x)));
        }
    }
}