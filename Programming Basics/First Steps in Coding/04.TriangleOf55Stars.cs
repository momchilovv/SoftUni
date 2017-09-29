using System;

namespace _04.TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            string star = "*";
            for (int row = 1; row <= 10; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    Console.Write($"{star}");
                }
                Console.WriteLine();
            }
        }
    }
}