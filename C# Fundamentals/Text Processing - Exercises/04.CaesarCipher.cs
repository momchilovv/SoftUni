using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string encrypted = null;

        foreach (var ch in text)
        {
            int value = ch + 3;
            encrypted += (char)value;
        }
        Console.WriteLine(encrypted);
    }
}