using System;

namespace _14.NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    int num = row + col + 1;
                    if (num > number)
                    {
                        num = 2 * number - num;
                    }
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}