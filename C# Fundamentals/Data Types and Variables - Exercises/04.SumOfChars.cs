using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < number; i++)
        {
            sum += char.Parse(Console.ReadLine());
        }
        Console.WriteLine($"The sum equals: {sum}");
    }
}