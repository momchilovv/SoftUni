using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var queue = new Queue<int>();

        foreach (var number in input)
        {
            if (number % 2 == 0)
            {
                queue.Enqueue(number);
            }
        }

        while (queue.Count > 0)
        {
            Console.Write(queue.Dequeue() + ", ");

            if (queue.Count == 1)
            {
                Console.Write(queue.Dequeue());
            }
        }
    }
}