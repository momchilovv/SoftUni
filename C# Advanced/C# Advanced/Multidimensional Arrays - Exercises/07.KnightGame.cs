using System;

internal class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        char[,] matrix = new char[number, number];

        for (int i = 0; i < number; i++)
        {
            var data = Console.ReadLine().ToCharArray();

            for (int j = 0; j < number; j++)
            {
                matrix[i, j] = data[j];
            }
        }

        int attackableKnights = 0;
        int maxAttackableKnights = -1;
        int bestKnightRow = 0;
        int bestKnightCol = 0;
        int count = 0;

        while (true)
        {
            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    if (matrix[row, col] == 'K')
                    {
                        if (row + 1 < number)
                        {
                            if (col - 2 >= 0)
                            {
                                if (matrix[row + 1, col - 2] == 'K')
                                {
                                    attackableKnights++;
                                }
                            }
                            if (col + 2 < number)
                            {
                                if (matrix[row + 1, col + 2] == 'K')
                                {
                                    attackableKnights++;
                                }
                            }
                        }
                        if (row - 1 >= 0)
                        {
                            if (col - 2 >= 0)
                            {
                                if (matrix[row - 1, col - 2] == 'K')
                                {
                                    attackableKnights++;
                                }
                            }
                            if (col + 2 < number)
                            {
                                if (matrix[row - 1, col + 2] == 'K')
                                {
                                    attackableKnights++;
                                }
                            }
                        }
                        if (row + 2 < number)
                        {
                            if (col + 1 < number)
                            {
                                if (matrix[row + 2, col + 1] == 'K')
                                {
                                    attackableKnights++;
                                }
                            }
                            if (col - 1 >= 0)
                            {
                                if (matrix[row + 2, col - 1] == 'K')
                                {
                                    attackableKnights++;
                                }
                            }
                        }
                        if (row - 2 >= 0)
                        {
                            if (col + 1 < number)
                            {
                                if (matrix[row - 2, col + 1] == 'K')
                                {
                                    attackableKnights++;
                                }
                            }
                            if (col - 1 >= 0)
                            {
                                if (matrix[row - 2, col - 1] == 'K')
                                {
                                    attackableKnights++;
                                }
                            }
                        }
                    }
                    if (attackableKnights > maxAttackableKnights)
                    {
                        maxAttackableKnights = attackableKnights;
                        bestKnightRow = row;
                        bestKnightCol = col;
                    }
                    attackableKnights = 0;
                }
            }
            if (maxAttackableKnights != 0)
            {
                matrix[bestKnightRow, bestKnightCol] = '0';
                maxAttackableKnights = 0;
                count++;
            }
            else
            {
                Console.WriteLine(count);
                Environment.Exit(0);
            }
        }
    }
}