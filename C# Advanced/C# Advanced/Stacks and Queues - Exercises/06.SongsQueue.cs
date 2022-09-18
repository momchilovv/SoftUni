using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(", ");

        var queue = new Queue<string>(input);

        while (queue.Any())
        {
            var command = Console.ReadLine();

            if (command.StartsWith("Add"))
            {
                var song = command.Substring(4);
                if (!queue.Contains(song))
                {
                    queue.Enqueue(song);
                }
                else
                {
                    Console.WriteLine($"{song} is already contained!");
                }
            }
            else if (command == "Show")
            {
                Console.WriteLine(string.Join(", ", queue));
            }

            else
            {
                queue.Dequeue();
            }
        }
        Console.WriteLine("No more songs!");
    }
}