using System;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string fixedText = null;
        char previousChar = '0';

        foreach (var ch in text)
        {
            if (ch != previousChar) 
            {
                fixedText += ch;
            }

            previousChar = ch;
        }

        Console.WriteLine(fixedText);
    }
}