using System;
using System.Collections.Generic;
using System.Security.Cryptography;

internal class Program
{
    static void Main(string[] args)
    {
        var queue = new Queue<string>();

        var kids = Console.ReadLine().Split();
        var number = int.Parse(Console.ReadLine());

        foreach (var kid in kids)
        {
            queue.Enqueue(kid);
        }
        while (queue.Count > 1)
        {
            for (int i = 1; i < number; i++)
            {
                var kid = queue.Dequeue();
                queue.Enqueue(kid);
            }
            Console.WriteLine($"Removed {queue.Dequeue()}");
        }
        Console.WriteLine($"Last is {queue.Dequeue()}");
    }
}