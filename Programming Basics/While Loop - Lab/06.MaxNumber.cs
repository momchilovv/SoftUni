using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        List<int> numbers = new List<int>();

        while (input != "Stop")
        {
            numbers.Add(int.Parse(input));
            input = Console.ReadLine();
        }
        Console.WriteLine(numbers.Max());
    }
}