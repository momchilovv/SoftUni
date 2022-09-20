using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        int rows = input[0], cols = input[1];

        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = data[j];
            }
        }

        for (int i = 0; i < cols; i++)
        {
            int colSum = 0;

            for (int j = 0; j < rows; j++)
            {
                colSum += matrix[j, i];
            }
            Console.WriteLine(colSum);
        }
    }
}