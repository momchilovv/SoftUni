using System;

namespace _01.DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());

            Console.Write($"{one:d4} {two:d4} {three:d4} {four:d4}");
            Console.WriteLine();
        }
    }
}
