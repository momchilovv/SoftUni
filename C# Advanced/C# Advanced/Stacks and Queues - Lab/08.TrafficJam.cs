using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var queue = new Queue<string>();

        var number = int.Parse(Console.ReadLine());

        var command = Console.ReadLine();

        var totalCars = 0;

        while (command != "end")
        {
            if (command == "green")
            {
                for (int i = 0; i < number; i++)
                {
                    if (queue.Count > 0)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        totalCars++;
                    }
                }
            }
            else
            {
                queue.Enqueue(command);
            }

            command = Console.ReadLine();
        }
        Console.WriteLine($"{totalCars} cars passed the crossroads.");
    }
}