using System;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string digits = null, letters = null, symbols = null;

        foreach (var ch in text)
        {
            if (char.IsDigit(ch))
            {
                digits += ch;
            }
            else if (char.IsLetter(ch))
            {
                letters += ch;
            }
            else
            {
                symbols += ch;
            }
        }

        Console.WriteLine(digits);
        Console.WriteLine(letters);
        Console.WriteLine(symbols);
    }
}