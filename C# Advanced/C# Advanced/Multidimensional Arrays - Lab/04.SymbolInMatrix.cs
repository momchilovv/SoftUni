using System;

internal class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        char[,] matrix = new char[number, number];

        for (int i = 0; i < number; i++)
        {
            string data = Console.ReadLine();

            for (int j = 0; j < number; j++)
            {
                matrix[i, j] = data[j];
            }
        }

        char symbol = char.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {
                if (matrix[i, j] == symbol)
                {
                    Console.WriteLine($"({i}, {j})");
                    Environment.Exit(0);    
                }
            }
        }
        Console.WriteLine($"{symbol} does not occur in the matrix");
    }
}