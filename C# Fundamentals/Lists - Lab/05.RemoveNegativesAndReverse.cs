using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        foreach (var number in numbers.ToList())
        {
            if (number < 0)
            {
                numbers.Remove(number);
            }
        }
        if (numbers.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            numbers.Reverse();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}