using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> morseAlphabet = new Dictionary<string, string>()
        {
            { "A", ".-" }, { "B", "-..." }, { "C", "-.-." }, { "D", "-.." }, { "E", "." },
            { "F", "..-." }, { "G", "--." }, { "H", "...." }, { "I", ".." }, { "J", ".---" },
            { "K", "-.-" }, { "L", ".-.." }, { "M", "--" }, { "N", "-." }, { "O", "---" },
            { "P", ".--." }, { "Q", "--.-" }, { "R", ".-." }, { "S", "..." }, { "T", "-" },
            { "U", "..-" }, { "V", "...-" }, { "W", ".--" }, { "X", "-..-" }, { "Y", "-.--" },
            { "Z", "--.." }
        };

        string[] input = Console.ReadLine().Split("|");
        string key = string.Empty;

        string decrypted = string.Empty;

        foreach (var word in input)
        {
            foreach (var letter in word.Split())
            {
                if (morseAlphabet.ContainsValue(letter))
                {
                    key = morseAlphabet.FirstOrDefault(k => k.Value == letter).Key;
                    decrypted += key;
                }
            }
            decrypted += " ";
        }
        Console.WriteLine(decrypted);
    }
}