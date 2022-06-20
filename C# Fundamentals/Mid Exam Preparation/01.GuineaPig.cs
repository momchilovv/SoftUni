using System;

class Program
{
    static void Main(string[] args)
    {
        double food = double.Parse(Console.ReadLine());
        double hay = double.Parse(Console.ReadLine());
        double cover = double.Parse(Console.ReadLine());
        double pigsWeight = double.Parse(Console.ReadLine());

        for (int i = 1; i <= 30; i++)
        {
            food -= 0.300;
            if (i % 2 == 0)
            {
                hay -= food * 0.05;
            }
            if ((i % 3) == 0)
            {
                cover -= pigsWeight * 0.3333;
            }

            if (food <= 0 || hay <= 0 || cover <= 0)
            {
                Console.WriteLine("Merry must go to the pet store!");
                Environment.Exit(0);
            }
        }
        Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:f2}, Hay: {hay:f2}, Cover: {cover:f2}.");
    }
}