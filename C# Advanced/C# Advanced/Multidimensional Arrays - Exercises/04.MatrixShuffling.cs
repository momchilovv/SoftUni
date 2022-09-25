using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] dimensions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int rows = dimensions[0], cols = dimensions[1];

        string[,] matrix = new string[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = data[j];
            }
        }

        string[] command = Console.ReadLine().Split();

        string[,] tempMatrix = new string[1, 1];

        while (command[0] != "END")
        {
            if (command[0] == "swap" && command.Length == 5)
            {
                int row1 = int.Parse(command[1]);
                int col1 = int.Parse(command[2]);
                int row2 = int.Parse(command[3]);
                int col2 = int.Parse(command[4]);

                try
                {
                    tempMatrix[0, 0] = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = tempMatrix[0, 0];

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write($"{matrix[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            command = Console.ReadLine().Split();
        }
    }
}