using System;

class Program
{
    static void Main(string[] args)
    {
        int position = int.Parse(Console.ReadLine());
        long[] sequence = new long[50];

        sequence[0] = 1;
        sequence[1] = 1;

        if (position > 2)
        {
            for (int i = 2; i < position; i++)
            {
                sequence[i] = FibonacciRecursion(position);
            }
        }

        Console.WriteLine(sequence[position - 1]);
    }
    public static long FibonacciRecursion(int number)
    {
        if (number <= 2)
        {
            return 1;
        }
        return FibonacciRecursion(number - 1) + FibonacciRecursion(number - 2);
    }
}