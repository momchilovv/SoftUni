using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> list = new List<int>();

            foreach (var a in array)
            {
                list.Add(a);
            }
            list.Sort();
            Console.Write(string.Join(" <= ", list));
            Console.WriteLine();
        }
    }
}