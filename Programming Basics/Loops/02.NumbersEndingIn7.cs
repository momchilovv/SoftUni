using System;

namespace _02.NumbersEndingIn7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (!(i % 10 == 7))
                    continue;
                else
                    Console.WriteLine(i);
            }
        }
    }
}