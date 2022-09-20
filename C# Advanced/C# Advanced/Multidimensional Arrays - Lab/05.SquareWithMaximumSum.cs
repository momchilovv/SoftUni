using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        int row = input[0], col = input[1];

        int[,] matrix = new int[row, col];

        int sum = int.MinValue;

        int[,] submatrix = new int[2, 2];

        for (int i = 0; i < row; i++)
        {
            int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            for (int j = 0; j < col; j++)
            {
                matrix[i, j] = data[j];
            }
        }

        for (int i = 0; i < row - 1; i++)
        {
            for (int j = 0; j < col - 1; j++)
            {
                int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                if (currentSum > sum)
                {
                    submatrix[0, 0] = matrix[i, j];
                    submatrix[0, 1] = matrix[i, j + 1];
                    submatrix[1, 0] = matrix[i + 1, j];
                    submatrix[1, 1] = matrix[i + 1, j + 1];

                    sum = currentSum;
                }
            }
        }

        Console.WriteLine($"{submatrix[0, 0]} {submatrix[0, 1]}");
        Console.WriteLine($"{submatrix[1, 0]} {submatrix[1, 1]}");
        Console.WriteLine(sum);
    }
}