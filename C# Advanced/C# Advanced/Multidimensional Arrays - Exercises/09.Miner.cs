using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        char[,] matrix = new char[number, number];

        string[] input = Console.ReadLine().Split();

        int coals = 0;
        int[] position = new int[2];

        for (int row = 0; row < number; row++)
        {
            char[] data = Console.ReadLine().Split().Select(char.Parse).ToArray();

            for (int col = 0; col < number; col++)
            {
                matrix[row, col] = data[col];

                if (data[col] == 'c')
                {
                    coals++;
                }
                else if (data[col] == 's')
                {
                    position[0] = row;
                    position[1] = col;
                }
            }
        }

        int collected = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == "up")
            {
                if (position[0] - 1 >= 0)
                {
                    position[0] -= 1;
                    
                    if (matrix[position[0], position[1]] == 'c')
                    {
                        matrix[position[0], position[1]] = '*';
                        coals--;
                        collected++;
                    }
                    
                    else if (matrix[position[0], position[1]] == 'e')
                    {
                        Console.WriteLine($"Game over! ({position[0]}, {position[1]})");
                        Environment.Exit(0);
                    }
                }
            }

            if (input[i] == "down")
            {
                if (position[0] + 1 < number)
                {
                    position[0] += 1;

                    if (matrix[position[0], position[1]] == 'c')
                    {
                        matrix[position[0], position[1]] = '*';
                        coals--;
                        collected++;
                    }

                    else if (matrix[position[0], position[1]] == 'e')
                    {
                        Console.WriteLine($"Game over! ({position[0]}, {position[1]})");
                        Environment.Exit(0);
                    }
                }
            }

            if (input[i] == "left")
            {
                if (position[1] - 1 >= 0)
                {
                    position[1] -= 1;

                    if (matrix[position[0], position[1]] == 'c')
                    {
                        matrix[position[0], position[1]] = '*';
                        coals--;
                        collected++;
                    }

                    else if (matrix[position[0], position[1]] == 'e')
                    {
                        Console.WriteLine($"Game over! ({position[0]}, {position[1]})");
                        Environment.Exit(0);
                    }
                }
            }

            if (input[i] == "right")
            {
                if (position[1] + 1 < number)
                {
                    position[1] += 1;

                    if (matrix[position[0], position[1]] == 'c')
                    {
                        matrix[position[0], position[1]] = '*';
                        coals--;
                        collected++;
                    }

                    else if (matrix[position[0], position[1]] == 'e')
                    {
                        Console.WriteLine($"Game over! ({position[0]}, {position[1]})");
                        Environment.Exit(0);
                    }
                }
            }
        }

        if (coals == 0)
        {
            Console.WriteLine($"You collected all coals! ({position[0]}, {position[1]})");
        }
        else
        {
            Console.WriteLine($"{coals} coals left. ({position[0]}, {position[1]})");
        }
    }
}