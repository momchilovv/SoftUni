using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AppendList
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split('|')
                .ToList();
            input.Reverse();

            var list = new List<string>();
            foreach (var item in input)
            {
                List<string> nums = item.Split(' ').ToList();
                foreach (var num in nums)
                {
                    if (num != "")
                    {
                        list.Add(num);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}