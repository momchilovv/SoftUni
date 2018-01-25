using System;
using System.Linq;

namespace _02.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();
            int[,] matrix = new int[rowAndCol[0], rowAndCol[1]];
            for (int i = 0; i < rowAndCol[0]; i++)
            {
                int[] rowValues = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None).Select(int.Parse).ToArray();
                for (int j = 0; j < rowAndCol[1]; j++)
                {
                    matrix[i, j] = rowValues[j];
                }
            }
            int sum = 0;
            int rowIndex = 0, columnIndex = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int tempSum = matrix[i, j] + matrix[i, j + 1] +
                                  matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        rowIndex = i;
                        columnIndex = j;
                    }
                }
            }
            Console.WriteLine(matrix[rowIndex, columnIndex] + " " + matrix[rowIndex, columnIndex + 1]);
            Console.WriteLine(matrix[rowIndex + 1, columnIndex] + " " + matrix[rowIndex + 1, columnIndex + 1]);
            Console.WriteLine(sum);
        }
    }
}