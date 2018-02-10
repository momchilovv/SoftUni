using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string[]> numbers = () => Console.ReadLine().Split().ToArray();

            Action<List<int>> result = number => Console.WriteLine(string.Join(" ", number));
            List<int> list = new List<int>();

            var input = numbers();
            foreach (var num in input)
            {
                var parsed = int.Parse(num);
                list.Add(parsed);
            }

            while (input[0] != "end")
            {
                if (input[0] == "add")
                {
                    list = list.Select(n => n + 1).ToList();
                }
                else if (input[0] == "multiply")
                {
                    list = list.Select(n => n * 2).ToList();
                }
                else if (input[0] == "subtract")
                {
                    list = list.Select(n => n - 1).ToList();
                }
                else if (input[0] == "print")
                {
                    result(list);
                }
                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}