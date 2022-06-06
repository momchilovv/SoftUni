using System;

class Program
{
    static void Main(string[] args)
    {
        PrintTriangle(int.Parse(Console.ReadLine()));
    }
    public static void PrintTriangle(int length)
    {
        for (int i = 1; i <= length; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine(); 
        }
        for (int i = length - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }
    }
}