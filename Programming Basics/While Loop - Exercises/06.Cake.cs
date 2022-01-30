using System;

class Program
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());

        int pieces = width * length;

        while (pieces >= 0)
        {
            string take = Console.ReadLine();

            if (take == "STOP")
            {
                Console.WriteLine($"{pieces} pieces are left.");
                System.Environment.Exit(0);
            }

            pieces -= int.Parse(take);
        }
        Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
    }
}