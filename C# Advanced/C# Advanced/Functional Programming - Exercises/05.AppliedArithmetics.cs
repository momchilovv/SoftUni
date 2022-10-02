using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        Action<List<int>> add = numbers =>
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]++;
            }
        };

        Action<List<int>> subtract = numbers =>
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        };

        Action<List<int>> multiply = numbers =>
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] *= 2;
            }
        };

        Func<List<int>, string> print = numbers => string.Join(" ", numbers);

        string command = Console.ReadLine();

        while (command != "end")
        {
            switch (command)
            {
                case "add":
                    add(numbers);
                    break;
                case "subtract":
                    subtract(numbers);
                    break;
                case "multiply":
                    multiply(numbers);
                    break;
                case "print":
                    Console.WriteLine(print(numbers));
                    break;
            }
            command = Console.ReadLine();
        }
    }
}