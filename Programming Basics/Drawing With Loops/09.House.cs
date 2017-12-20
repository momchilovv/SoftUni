using System;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfRows = n / 2 + n % 2;
            int numberOfStars = 0;
            if (n % 2 == 0)
            {
                numberOfStars = 2;
            }
            else
                numberOfStars = 1;
            for (int i = 0; i < numberOfRows; i++)
            {
                int numberOfDashes = (n - numberOfStars) / 2;
                Console.Write(new string('-', numberOfDashes));
                Console.Write(new string('*', numberOfStars));
                Console.WriteLine(new string('-', numberOfDashes));
                numberOfStars += 2;
            }
            numberOfRows = n / 2;
            for (int i = 0; i < numberOfRows; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', n - 2));
                Console.WriteLine('|');
            }
        }
    }
}