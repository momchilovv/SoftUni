using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int health = 100, bitcoins = 0, roomCount = 0;

        List<string[]> rooms = new List<string[]>();

        string[] input = Console.ReadLine().Split("|");

        foreach (var room in input)
        {
            rooms.Add(room.Split(" "));
        }
        foreach (var room in rooms)
        {
            roomCount++;

            if (room[0] == "potion")
            {
                if (int.Parse(room[1]) + health > 100)
                {
                    Console.WriteLine($"You healed for {100 - health} hp.");
                    health += 100 - health;
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else
                {
                    Console.WriteLine($"You healed for {int.Parse(room[1])} hp.");
                    health += int.Parse(room[1]);
                    Console.WriteLine($"Current health: {health} hp.");
                }
            }
            else if (room[0] == "chest")
            {
                Console.WriteLine($"You found {room[1]} bitcoins.");
                bitcoins += int.Parse(room[1]);
            }
            else
            {
                if (int.Parse(room[1]) >= health)
                {
                    Console.WriteLine($"You died! Killed by {room[0]}.");
                    Console.WriteLine($"Best room: {roomCount}");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine($"You slayed {room[0]}.");
                    health -= int.Parse(room[1]);
                }
            }
        }
        Console.WriteLine("You've made it!");
        Console.WriteLine($"Bitcoins: {bitcoins}");
        Console.WriteLine($"Health: {health}");
    }
}