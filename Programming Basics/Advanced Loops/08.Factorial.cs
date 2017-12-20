using System;

namespace _08.Factiorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            do
            {
                factorial = factorial * number;
                number--;
            } while (number > 1);
            Console.WriteLine(factorial);
        }
    }
}