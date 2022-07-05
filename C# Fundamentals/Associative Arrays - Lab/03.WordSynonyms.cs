using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            string word = Console.ReadLine();

            string synonym = Console.ReadLine();

            if (!synonyms.ContainsKey(word))
            {
                List<string> list = new List<string>();
                list.Add(synonym);
                synonyms.Add(word, list);
            }
            else
            {
                List<string> list = synonyms[word];
                if (!list.Contains(synonym))
                {
                    list.Add(synonym);
                }
            }
        }
        foreach (var word in synonyms)
        {
            Console.Write($"{word.Key} - ");
            Console.WriteLine(string.Join(", ", word.Value));
        }
    }
}