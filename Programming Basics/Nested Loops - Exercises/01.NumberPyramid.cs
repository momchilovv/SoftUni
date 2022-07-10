using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        int current = 1;

        for (int i = 1; i <= number; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (current > number)
                {
                    break;
                }
                Console.Write($"{current} ");
                current++;
            }
            if (current > number)
            {
                break;
            }
            Console.WriteLine();
        }
    }
}