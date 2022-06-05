using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int wagons = int.Parse(Console.ReadLine());
        int[] passangers = new int[wagons];

        for (int i = 0; i < wagons; i++)
        {
            passangers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(string.Join(" ", passangers));
        Console.WriteLine(passangers.Sum());
    }
}