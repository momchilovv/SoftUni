using System;

class Program
{
    static void Main(string[] args)
    {
        string[] bannedWords = Console.ReadLine().Split(", ");
        string text = Console.ReadLine();
        string replacedWord = "*";

        for (int i = 0; i < bannedWords.Length; i++)
        {
            for (int j = 0; j < bannedWords[i].Length - 1; j++)
            {
                replacedWord += "*";
            }

            while (text.Contains(bannedWords[i]))
            {
                text = text.Replace(bannedWords[i], replacedWord);
                replacedWord = "*";
            }
        }

        Console.WriteLine(text);
    }
}