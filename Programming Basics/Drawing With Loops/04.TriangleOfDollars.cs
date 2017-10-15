using System;

namespace _04.TriangleOfDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row < n; row++)
            {
                Console.Write("$");
                for (int col = 0; col < row; col++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}