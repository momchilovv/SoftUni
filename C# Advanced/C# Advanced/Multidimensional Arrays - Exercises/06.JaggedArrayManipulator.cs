using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());

        int[][] jaggedArray = new int[rows][];

        for (int row = 0; row < rows; row++)
        {
            jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        for (int row = 0; row < rows; row++)
        {
            if (row == rows - 1)
            {
                break;
            }
            if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
            {
                for (int el = 0; el < jaggedArray[row].Length; el++)
                {
                    jaggedArray[row][el] *= 2;
                    jaggedArray[row + 1][el] *= 2;
                }
            }
            else
            {
                for (int el = 0; el < jaggedArray[row].Length; el++)
                {
                    jaggedArray[row][el] /= 2;
                }
                for (int el = 0; el < jaggedArray[row + 1].Length; el++)
                {
                    jaggedArray[row + 1][el] /= 2;
                }
            }
        }

        string[] command = Console.ReadLine().Split();

        while (command[0] != "End")
        {
            int row = int.Parse(command[1]);
            int col = int.Parse(command[2]);
            int value = int.Parse(command[3]);

            try
            {
                if (command[0] == "Add")
                {
                    jaggedArray[row][col] += value;
                }
                else
                {
                    jaggedArray[row][col] -= value;
                }
            }
            catch (IndexOutOfRangeException)
            {

            }

            command = Console.ReadLine().Split();
        }

        for (int row = 0; row < rows; row++)
        {
            Console.WriteLine(String.Join(" ", jaggedArray[row]));
        }
    }
}