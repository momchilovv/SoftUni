using System;

public class Program
{
    public static int carRow = 0;
    public static int carCol = 0;

    public static int firstLocaitonRow = -1;
    public static int firstLocaitonCol = -1;

    public static int secondLocaitonRow = -1;
    public static int secondLocaitonCol = -1;

    public static int finishRow = -1;
    public static int finishCol = -1;

    public static int kilometersCovered = 0;

    public static bool hasFinished = false;

    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string racingNumber = Console.ReadLine();

        char[,] track = new char[n, n];

        for (int i = 0; i < n; i++)
        {
            int counter = 0;

            char[] input = Console.ReadLine().Replace(" ", "").ToCharArray();

            foreach (var ch in input)
            {
                track[i, counter] = ch;

                if (ch == 'T')
                {
                    if (firstLocaitonRow < 0 && firstLocaitonCol < 0)
                    {
                        firstLocaitonRow = i;
                        firstLocaitonCol = counter;
                    }
                    else
                    {
                        secondLocaitonRow = i;
                        secondLocaitonCol = counter;
                    }
                }
                else if (ch == 'F')
                {
                    finishRow = i;
                    finishCol = counter;
                }

                counter++;
            }
            track[0, 0] = 'C';
        }
        
        string command = Console.ReadLine();

        while (command != "End")
        {
            switch (command)
            {
                case "up":
                    Move(-1, 0, track);
                    break;
                case "down":
                    Move(1, 0, track);
                    break;
                case "left":
                    Move(0, -1, track);
                    break;
                case "right":
                    Move(0, 1, track);
                    break;
            }

            if (hasFinished) break;

            command = Console.ReadLine();
        }

        if (hasFinished)
        {
            Console.WriteLine($"Racing car {racingNumber} finished the stage!");
        }
        else
        {
            Console.WriteLine($"Racing car {racingNumber} DNF.");
        }

        Console.WriteLine($"Distance covered {kilometersCovered} km.");

        PrintTrack(track);
    }

    public static bool IsValidPosition(int row, int col, char[,] track)
    {
        return row >= 0 && row < track.GetLength(0) && col >= 0 && col < track.GetLength(1);
    }

    public static void Move(int row, int col, char[,] track)
    {
        if (IsValidPosition(carRow + row, carCol + col, track))
        {
            if (track[carRow + row, carCol + col] == 'T')
            {
                track[carRow, carCol] = '.';

                carRow += row;
                carCol += col;

                if (carRow == firstLocaitonRow && carCol == firstLocaitonCol)
                {
                    carRow = secondLocaitonRow;
                    carCol = secondLocaitonCol;

                    track[firstLocaitonRow, firstLocaitonCol] = '.';
                }
                else
                {
                    carRow = firstLocaitonRow;
                    carCol = firstLocaitonCol;

                    track[secondLocaitonRow, secondLocaitonCol] = '.';
                }
                kilometersCovered += 30;
            }

            else if (track[carRow + row, carCol + col] == 'F')
            {
                track[carRow, carCol] = '.';

                carRow += row;
                carCol += col;
                kilometersCovered += 10;
                hasFinished = true;
            }

            else
            {
                track[carRow, carCol] = '.';

                carRow += row;
                carCol += col;

                kilometersCovered += 10;
            }
            track[carRow, carCol] = 'C';
        }
    }

    public static void PrintTrack(char[,] track)
    {
        for (int i = 0; i < track.GetLength(0); i++)
        {
            for (int j = 0; j < track.GetLength(1); j++)
            {
                Console.Write(track[i, j]);
            }
            Console.WriteLine();
        }
    }
}