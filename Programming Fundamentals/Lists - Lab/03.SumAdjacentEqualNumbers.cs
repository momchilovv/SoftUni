using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            var list = new List<double>();

            foreach (var nums in input)
            {
                list.Add(nums);
            }
            for (int i = 0; i < list.Count - 1; i++)
            {
                while (i < list.Count - 1)
                {
                    if (list[i] == list[i + 1])
                    {
                        list[i] = list[i] + list[i + 1];
                        list.RemoveAt(i + 1);
                        if (i > 0)
                            i--;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}