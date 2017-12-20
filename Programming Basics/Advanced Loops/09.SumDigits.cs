using System;

namespace _09.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            do
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                number /= 10;
            } while (number > 0);
            Console.WriteLine(sum);
        }
    }
}