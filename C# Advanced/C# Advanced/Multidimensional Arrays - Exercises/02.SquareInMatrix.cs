using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int rows = dimensions[0], cols = dimensions[1];

        char[,] matrix = new char[rows, cols];

        int counter = 0;

        for (int i = 0; i < rows; i++)
        {
            char[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = data[j];
            }
        }

        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                char currentChar = matrix[row, col];

                if (currentChar == matrix[row, col + 1] && 
                    currentChar == matrix[row + 1, col] &&
                    currentChar == matrix[row + 1, col + 1])
                {
                    counter++;
                }
            }
        }

        Console.WriteLine(counter);
    }
}