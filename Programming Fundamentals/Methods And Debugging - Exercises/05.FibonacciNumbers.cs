using System;

namespace _05.FibonacciNumbers
{
    class Program
    {
        static void Fibonacci(int number)
        {
            int current = 1;
            int previous = 1;

            for (int i = 0; i < number; i++)
            {
                int temp = current + previous;
                current = previous;
                previous = temp;
            }
            Console.WriteLine(current);
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Fibonacci(number);
        }
    }
}