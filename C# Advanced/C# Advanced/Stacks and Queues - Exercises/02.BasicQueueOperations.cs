using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var queue = new Queue<int>();

        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int s = input[1];
        int x = input[2];

        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < n; i++)
        {
            queue.Enqueue(numbers[i]);
        }

        for (int i = 0; i < s; i++)
        {
            queue.Dequeue();
        }

        if (queue.Count == 0)
        {
            Console.WriteLine("0");
            return;
        }

        if (queue.Contains(x))
        {
            Console.WriteLine(true.ToString().ToLower());
        }

        else
        {
            Console.WriteLine(queue.Min());
        }
    }
}