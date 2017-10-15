using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                list.Add(num);
            }
            Console.WriteLine($"{list.Min()}");
        }
    }
}