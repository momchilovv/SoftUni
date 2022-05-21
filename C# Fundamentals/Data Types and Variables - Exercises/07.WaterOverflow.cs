using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int capacity = 255;

        for (int i = 0; i < number; i++)
        {
            int pour = int.Parse(Console.ReadLine());

            if (pour > capacity)
            {
                Console.WriteLine("Insufficient capacity!");
            }
            else
            {
                capacity -= pour;
            }
        }
        Console.WriteLine(Math.Abs(capacity - 255));
    }
}