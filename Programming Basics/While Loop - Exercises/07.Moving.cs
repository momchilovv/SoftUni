using System;

class Program
{
    static void Main(string[] args)
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());

        int freeSpace = width * length * height;

        string boxes = Console.ReadLine();
        int boxesSpace = 0;

        while (boxes != "Done")
        {    
            boxesSpace += int.Parse(boxes);

            if (freeSpace <= boxesSpace)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace - boxesSpace)} Cubic meters more.");
                System.Environment.Exit(0);
            }
            boxes = Console.ReadLine();
        }
        Console.WriteLine($"{freeSpace - boxesSpace} Cubic meters left.");
    }
}