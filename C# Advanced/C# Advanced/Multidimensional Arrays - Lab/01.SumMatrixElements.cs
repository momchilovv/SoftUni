using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        int rows = input[0], cols = input[1];

        int[,] matrix = new int[rows, cols];

        int sumOfElements = 0;

        for (int i = 0; i < rows; i++)
        {
            int[] data = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = data[j];
            }
        }

        foreach (var element in matrix)
        {
            sumOfElements += element;
        }
        Console.WriteLine(rows);
        Console.WriteLine(cols);
        Console.WriteLine(sumOfElements);
    }
}