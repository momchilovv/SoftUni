using System;

namespace _13.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchCounter = 0;
            int sum = 0;
            int counter = 0;
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            for (int i = m; i >= n; i--)
            {
                for (int j = m; j >= n; j--)
                {
                    sum = i + j;
                    counter++;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine("Number found! {0} + {1} = {2}", i, j, magicNumber);
                        matchCounter++;
                        return;
                    }
                }
            }
            if (matchCounter == 0)
            {
                Console.WriteLine("{0} combinations - neither equals {1}", counter, magicNumber);
            }
        }
    }
}
