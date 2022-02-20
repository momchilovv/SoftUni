using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int goals = int.Parse(Console.ReadLine());
        int currentBest = goals;
        string currentPlayer = name;

        while (name != "END")
        {
            if (goals >= 10)
            {
                Console.WriteLine($"{name} is the best player!");
                Console.WriteLine($"He has scored {goals} goals and made a hat-trick !!!");
                System.Environment.Exit(0);
            }
            if (goals > currentBest)
            {
                currentBest = goals;
                currentPlayer = name;
            }

            name = Console.ReadLine();
            if (name == "END")
            {
                break;
            }
            goals = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"{currentPlayer} is the best player!");
        if (currentBest >= 3)
        {
            Console.WriteLine($"He has scored {currentBest} goals and made a hat-trick !!!");
        }
        else
        {
            Console.WriteLine($"He has scored {currentBest} goals.");
        }
    }
}