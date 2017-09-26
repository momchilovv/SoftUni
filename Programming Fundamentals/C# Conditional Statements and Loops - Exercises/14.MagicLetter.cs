using System;

namespace _14.MagicLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine().ToLower());
            char secondLetter = char.Parse(Console.ReadLine().ToLower());
            char ignoredLetter = char.Parse(Console.ReadLine().ToLower());

            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        if (!i.Equals(ignoredLetter) && !j.Equals(ignoredLetter) && !k.Equals(ignoredLetter))
                        {
                            Console.Write($"{i}{j}{k}" + " ");
                        }
                    }
                }
            }
        }
    }
}