using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        char[,] matrix = new char[numbers[0], numbers[1]];

        int[] position = new int[2];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            char[] elements = Console.ReadLine().ToCharArray();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[row, i] = elements[i];
                if (elements[i] == 'P')
                {
                    position[0] = row;
                    position[1] = i;
                }
            }
        }

        bool isAlive = true, hasWon = false;

        char[] input = Console.ReadLine().ToCharArray();

        for (int i = 0; i < input.Length; i++)
        {
            switch (input[i])
            {
                case 'U':
                    if (position[0] - 1 >= 0)
                    {
                        if (matrix[position[0] - 1, position[1]] == 'B')
                        {
                            isAlive = false;
                        }
                        else
                        {
                            matrix[position[0] - 1, position[1]] = 'P';
                        }
                        matrix[position[0], position[1]] = '.';
                        position[0] -= 1;
                    }
                    else
                    {
                        hasWon = true;
                        matrix[position[0], position[1]] = '.';
                    }
                    break;

                case 'D':
                    if (position[0] + 1 < matrix.GetLength(0))
                    {
                        if (matrix[position[0] + 1, position[1]] == 'B')
                        {
                            isAlive = false;
                        }
                        else
                        {
                            matrix[position[0] + 1, position[1]] = 'P';
                        }
                        matrix[position[0], position[1]] = '.';
                        position[0] += 1;
                    }
                    else
                    {
                        hasWon = true;
                        matrix[position[0], position[1]] = '.';
                    }
                    break;

                case 'L':
                    if (position[1] - 1 >= 0)
                    {
                        if (matrix[position[0], position[1] - 1] == 'B')
                        {
                            isAlive = false;
                        }
                        else
                        {
                            matrix[position[0], position[1] - 1] = 'P';
                        }
                        matrix[position[0], position[1]] = '.';
                        position[1] -= 1;
                    }
                    else
                    {
                        hasWon = true;
                        matrix[position[0], position[1]] = '.';
                    }
                    break;

                case 'R':
                    if (position[1] + 1 < matrix.GetLength(1))
                    {
                        if (matrix[position[0], position[1] + 1] == 'B')
                        {
                            isAlive = false;
                        }
                        else
                        {
                            matrix[position[0], position[1] + 1] = 'P';
                        }
                        matrix[position[0], position[1]] = '.';
                        position[1] += 1;
                    }
                    else
                    {
                        matrix[position[0], position[1]] = '.';
                        hasWon = true;
                    }
                    break;
            }

            char[,] matrixCopy = (char[,])matrix.Clone();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        if (row - 1 >= 0)
                        {
                            if (matrix[row - 1, col] == 'P')
                            {
                                isAlive = false;
                            }
                            matrixCopy[row - 1, col] = 'B';
                        }
                        if (row + 1 < matrix.GetLength(0))
                        {
                            if (matrix[row + 1, col] == 'P')
                            {
                                isAlive = false;
                            }
                            matrixCopy[row + 1, col] = 'B';
                        }
                        if (col - 1 >= 0)
                        {
                            if (matrix[row, col - 1] == 'P')
                            {
                                isAlive = false;
                            }
                            matrixCopy[row, col - 1] = 'B';
                        }
                        if (col + 1 < matrix.GetLength(1))
                        {
                            if (matrix[row, col + 1] == 'P')
                            {
                                isAlive = false;
                            }
                            matrixCopy[row, col + 1] = 'B';
                        }
                    }
                }
            }

            matrix = (char[,])matrixCopy.Clone();
            if (isAlive == false)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    string line = string.Empty;
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        line += matrix[row, col];
                    }
                    Console.WriteLine(line);
                }
                Console.WriteLine($"dead: {position[0]} {position[1]}");
                Environment.Exit(0);
            }

            if (hasWon)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    string line = string.Empty;
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        line += matrix[row, col];
                    }
                    Console.WriteLine(line);
                }
                Console.WriteLine($"won: {position[0]} {position[1]}");
                Environment.Exit(0);
            }
        }
    }
}