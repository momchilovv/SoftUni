using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<double> list = new List<double>();

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                list.Add(number);
            }
            Console.WriteLine($"Sum = {list.Sum()}");
            Console.WriteLine($"Min = {list.Min()}");
            Console.WriteLine($"Max = {list.Max()}");
            Console.WriteLine($"Average = {list.Average()}");
        }
    }
}