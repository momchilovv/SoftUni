using System;

class Program
{
    static void Main(string[] args)
    {
        int dogFood = int.Parse(Console.ReadLine());
        int catFood = int.Parse(Console.ReadLine());

        Console.WriteLine($"{(dogFood * 2.50) + (catFood * 4)} lv.");
    }
}