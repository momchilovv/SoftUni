using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SortTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = Console.ReadLine().Split().ToList();
            var list = new List<string>();

            foreach (var time in times)
            {
                list.Add(time);
            }
            list.Sort();

            Console.WriteLine(string.Join(", ", list));
        }
    }
}