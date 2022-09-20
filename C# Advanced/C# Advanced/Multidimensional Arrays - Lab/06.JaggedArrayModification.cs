using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int[][] jaggedArray = new int[number][];

        for (int i = 0; i < number; i++)
        {
            jaggedArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        string[] command = Console.ReadLine().Split();

        while (command[0] != "END")
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
                Console.WriteLine("Invalid coordinates");
            }

            command = Console.ReadLine().Split();
        }

        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write($"{jaggedArray[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}