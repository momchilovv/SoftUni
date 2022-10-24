using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> comparator = (first, second) =>
            {
                if (first % 2 == 0 && second % 2 != 0)
                {
                    return -1;
                }

                if (first % 2 != 0 && second % 2 == 0)
                {
                    return 1;
                }

                return first.CompareTo(second);
            };

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Array.Sort(numbers, new Comparison<int>(comparator));

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}