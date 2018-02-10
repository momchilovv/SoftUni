using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[]> range = () => Console.ReadLine().Split().Select(int.Parse).ToArray();

            Action<List<int>> result = numbers => Console.WriteLine(string.Join(" ", numbers));

            List<int> nums = new List<int>();

            var input = range();
            var startIndex = input[0];
            var endIndex = input[1];

            var format = Console.ReadLine();
            if (format == "odd")
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    if (i % 2 == 1)
                    {
                        nums.Add(i);
                    }  
                }              
            }
            else if (format == "even")
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    if (i % 2 == 0)
                    {
                        nums.Add(i);
                    }
                }
            }
            result(nums);
        }
    }
}