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
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine(GetSmallestNumber(numbers));
    }
    public static int GetSmallestNumber(List<int> numbers)
    {
        return numbers.Min();
    }
}