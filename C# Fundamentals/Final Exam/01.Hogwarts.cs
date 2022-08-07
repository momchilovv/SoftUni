using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string spell = Console.ReadLine();

        string[] command = Console.ReadLine().Split();

        while (command[0] != "Abracadabra")
        {
            if (command[0] == "Abjuration")
            {
                spell = spell.ToUpper();
                Console.WriteLine(spell);
            }
            if (command[0] == "Necromancy")
            {
                spell = spell.ToLower();
                Console.WriteLine(spell);
            }
            if (command[0] == "Illusion")
            {
                int index = int.Parse(command[1]);

                if (index >= 0 && index < spell.Length)
                {
                    spell = spell.Remove(index, 1);
                    spell = spell.Insert(index, command[2]);

                    Console.WriteLine("Done!");
                }
                else
                {
                    Console.WriteLine("The spell was too weak.");
                }        
            }
            if (command[0] == "Divination")
            {
                string firstSubstring = command[1];
                string secondSubstring = command[2];

                if (spell.Contains(firstSubstring))
                {
                    spell = spell.Replace(firstSubstring, secondSubstring);
                    Console.WriteLine(spell);
                }
            }
            if (command[0] == "Alteration")
            {
                string substring = command[1];

                if (spell.Contains(substring))
                {
                    spell = spell.Replace(substring, string.Empty);
                    Console.WriteLine(spell);
                }
            }

            command = Console.ReadLine().Split();
        }
    }
}