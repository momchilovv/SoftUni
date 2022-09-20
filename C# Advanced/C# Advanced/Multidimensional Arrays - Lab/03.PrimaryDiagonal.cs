using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int[,] matrix = new int[number, number];

        int diagonalSum = 0;

        for (int i = 0; i < number; i++)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < number; j++)
            {
                matrix[i, j] = data[j];
            }
        }

        for (int i = 0; i < number; i++)
        {          
            diagonalSum += matrix[i, i];
        }
        Console.WriteLine(diagonalSum);
    }
}