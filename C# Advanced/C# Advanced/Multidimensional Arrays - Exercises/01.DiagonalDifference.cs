using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int[,] matrix = new int[number, number];

        int primarySum = 0, secondarySum = 0;

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
            primarySum += matrix[i, i];
        }

        int tempArray = number - 1;
        for (int i = 0; i < number; i++)
        {
            secondarySum += matrix[i, tempArray];
            tempArray--;
        }

        Console.WriteLine(Math.Abs(primarySum - secondarySum));
    }
}