using System;

class Program
{
    static void Main(string[] args)
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());
        int magicNumber = int.Parse(Console.ReadLine());

        int counter = 0;

        for (int i = startNumber; i <= endNumber; i++)
        {
            for (int j = startNumber; j <= endNumber; j++)
            {
                counter++;
                if (i + j == magicNumber)
                {
                    Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
                    System.Environment.Exit(0);
                }
            }
        }
        Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
    }
}