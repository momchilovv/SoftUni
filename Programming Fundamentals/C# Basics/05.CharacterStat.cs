using System;

namespace _05.CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.Write("Health: ");
            Console.Write(new string ('|', 1));
            Console.Write(new string ('|', currentHealth));
            Console.Write(new string ('.', maxHealth - currentHealth));
            Console.Write(new string ('|', 1));
            Console.WriteLine();

            ContextStaticAttribute void 
            Console.Write("Energy: ");
            Console.Write(new string('|', 1));
            Console.Write(new string('|', currentEnergy));
            Console.Write(new string('.', maxEnergy - currentEnergy));
            Console.Write(new string('|', 1));
            Console.WriteLine();
        }
    }
}
