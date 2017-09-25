using System;

namespace _07.CakeIngredience
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int iCount = 0;

            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                iCount++;

                input = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {iCount} ingredients.");
        }
    }
}