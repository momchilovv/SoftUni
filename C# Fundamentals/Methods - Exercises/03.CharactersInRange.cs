using System;

class Program
{
    static void Main(string[] args)
    {
        char firstChar = char.Parse(Console.ReadLine());
        char secondChar = char.Parse(Console.ReadLine());

        PrintAllCharacters(firstChar, secondChar);
    }
    public static void PrintAllCharacters(char firstChar, char secondChar)
    {

        for (int i = firstChar + 1; i < secondChar; i++)
        {
            Console.Write($"{(char)i} ");
        }

        for (int i = secondChar + 1; i < firstChar; i++)
        {
            Console.Write($"{(char)i} ");
        }
        Console.WriteLine();
    }
}