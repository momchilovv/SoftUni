using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Random randomize = new Random();
        List<string> input = Console.ReadLine().Split().ToList();

        while (input.Count > 0)
        {
            int index = randomize.Next(0, input.Count);
            Console.WriteLine(input[index]);
            input.RemoveAt(index);
        }
    }
}