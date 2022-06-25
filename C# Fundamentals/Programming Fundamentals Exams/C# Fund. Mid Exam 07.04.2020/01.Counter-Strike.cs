using System;

class Program
{
    static void Main(string[] args)
    {
        int energy = int.Parse(Console.ReadLine());
        int count = 0;

        string input = Console.ReadLine();

        while (input != "End of battle")
        {
            int distance = int.Parse(input);


            if (energy - distance < 0)
            {
                Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {energy} energy");
                Environment.Exit(0);
            }
            else
            {
                energy -= distance;
                count++;
            }
            if (count % 3 == 0)
            {
                energy += count;
            }
            input = Console.ReadLine();
        }
        Console.WriteLine($"Won battles: {count}. Energy left: {energy}");
    }
}