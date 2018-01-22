using System;
using System.Collections.Generic;

namespace _06.TrafficLight
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsPerGreen = int.Parse(Console.ReadLine());
            Queue<string> carsQueue = new Queue<string>();
            int carsPassedTotal = 0;

            string input = Console.ReadLine();
            while (input != "end")
            {
                if (input == "green")
                {
                    var carsThatCanPass = Math.Min(carsQueue.Count, carsPerGreen);
                    for (int i = 0; i < carsThatCanPass; i++)
                    {
                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        carsPassedTotal++;
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{carsPassedTotal} cars passed the crossroads.");
        }
    }
}