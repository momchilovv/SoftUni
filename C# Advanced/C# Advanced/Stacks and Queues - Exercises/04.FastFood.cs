using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var foodQuantity = int.Parse(Console.ReadLine());

        var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var queue = new Queue<int>(orders);

        Console.WriteLine(queue.Max());

        while (true)
        {
            if (foodQuantity - queue.Peek() >= 0)
            {
                foodQuantity -= queue.Dequeue();

                if (queue.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    return;
                }
            }
            else
            {
                break;
            }
        }
        Console.WriteLine($"Orders left: {String.Join(" ", queue)}");
    }
}