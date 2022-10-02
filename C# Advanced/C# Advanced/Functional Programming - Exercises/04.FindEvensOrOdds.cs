using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string state = Console.ReadLine();

        Console.WriteLine(string.Join(" ", NumbersInRange(state, numbers[0], numbers[1])));
    }

    static List<int> NumbersInRange(string state, int startNumber, int endNumber)
    {
        var numbers = new List<int>();

        Predicate<int> even = number => number % 2 == 0;
        Predicate<int> odd = number => number % 2 != 0;

        for (int i = startNumber; i <= endNumber; i++)
        {
            numbers.Add(i);
        }

        if (state == "even")
        {
            return numbers.FindAll(even); 
        }
        else
        {
            return numbers.FindAll(odd);
        }
    }
}