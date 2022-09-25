using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int rows = dimensions[0], cols = dimensions[1];

        char[,] matrix = new char[rows, cols];

        string text = Console.ReadLine();

        var snake = new Queue<char>(text);

        char symbol;

        for (int row = 0; row < rows; row++)
        {
            if (row % 2 != 0)
            {
                for (int col = cols - 1; col >= 0; col--)
                {
                    symbol = snake.Dequeue();
                    matrix[row, col] = symbol;
                    snake.Enqueue(symbol);
                }
            }
            else
            {
                for (int col = 0; col < cols; col++)
                {
                    symbol = snake.Dequeue();
                    matrix[row, col] = symbol;
                    snake.Enqueue(symbol);
                }
            }
        }

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}