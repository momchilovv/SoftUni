using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Func<int[]> allNumbers = () => Console.ReadLine().Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                Action<List<int>> sortedEvenNumbers = numbers => Console.WriteLine(string.Join(", ", numbers));

                var input = allNumbers();
                List<int> sortedNumbers = new List<int>();

                foreach (var number in input.OrderBy(x => x))
                {
                    if (number % 2 == 0)
                    {
                        sortedNumbers.Add(number);
                    }
                }
                sortedNumbers.Sort();
                sortedEvenNumbers(sortedNumbers);
            }
            catch (Exception)
            {
                Console.WriteLine();
            }
        }
    }
}