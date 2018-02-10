using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[]> numbers = () => Console.ReadLine().Split().Select(int.Parse).ToArray();

            Action<List<int>> result = number => Console.WriteLine(string.Join(" ", number));
            List<int> list = new List<int>();

            var input = numbers();
            var givenInteger = int.Parse(Console.ReadLine());

            foreach (var num in input)
            {
                if (num % givenInteger != 0)
                {
                    list.Add(num);
                }
            }
            list.Reverse();
            result(list);
        }
    }
}