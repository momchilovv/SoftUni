using System;

namespace _10.AnimalType
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            if (animal == "dog")
                Console.WriteLine("mammal");
            else if (animal == "snake" || animal == "crocodile" || animal == "tortoise")
                Console.WriteLine("reptile");
            else
                Console.WriteLine("unknown");
        }
    }
}