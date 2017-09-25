using System;

namespace _05.WorldInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            bool wordEnds = input.EndsWith("y");
            bool wordEnds2 = input.EndsWith("o") || input.EndsWith("s") || input.EndsWith("x") || input.EndsWith("z") || input.EndsWith("ch") || input.EndsWith("sh");

            if (wordEnds)
            {
                int removeLetter = input.Length - 1;
                input = input.Remove(removeLetter, 1);
                Console.WriteLine($"{input}ies");   }
            else if (wordEnds2)
                Console.WriteLine($"{input}es");
            else
                Console.WriteLine($"{input}s");
        }
    }
}