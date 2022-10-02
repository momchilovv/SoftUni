using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int num = int.Parse(Console.ReadLine());

        Predicate<int> divisible = number => number % num == 0;
        
        Action<List<int>> reverseList = numbers => numbers.Reverse();

        Func<List<int>, string> print = numbers => string.Join(" ", numbers);

        for (int i = 0; i < numbers.Count; i++)
        {
            if (divisible(numbers[i]))
            {
                numbers.Remove(numbers[i]);
                i--;
            }
        }
        reverseList(numbers);

        Console.WriteLine(print(numbers));
    }
}