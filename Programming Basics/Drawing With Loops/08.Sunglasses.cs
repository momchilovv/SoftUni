using System;

namespace _08.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
            int noseIndex = (n - 1) / 2 - 1;

            for (int row = 0; row < n - 2; row++)
            {
                if (row != noseIndex)
                {
                    Console.Write('*');
                    Console.Write(new string('/', 2 * n - 2));
                    Console.Write('*');
                    Console.Write(new string(' ', n));
                    Console.Write('*');
                    Console.Write(new string('/', 2 * n - 2));
                    Console.WriteLine('*');
                }
                else
                {
                    Console.Write('*');
                    Console.Write(new string('/', 2 * n - 2));
                    Console.Write('*');
                    Console.Write(new string('|', n));
                    Console.Write('*');
                    Console.Write(new string('/', 2 * n - 2));
                    Console.WriteLine('*');
                }
            }
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
        }
    }
}