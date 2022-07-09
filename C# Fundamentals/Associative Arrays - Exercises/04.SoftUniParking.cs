using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> cars = new Dictionary<string, string>();
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string[] input = Console.ReadLine().Split();

            if (input[0] == "register")
            {
                if (cars.ContainsKey(input[1]))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {cars[input[1]]}");
                }
                else
                {
                    cars.Add(input[1], input[2]);
                    Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                }
            }
            else
            {
                if (!cars.ContainsKey(input[1]))
                {
                    Console.WriteLine($"ERROR: user {input[1]} not found");
                }
                else
                {
                    cars.Remove(input[1]);
                    Console.WriteLine($"{input[1]} unregistered successfully");
                }
            }
        }
        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Key} => {car.Value}");
        }
    }
}