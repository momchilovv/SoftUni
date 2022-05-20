using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < 3; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        foreach (var item in numbers.OrderByDescending(x => x))
        {
            Console.WriteLine(item);
        }
    }
}