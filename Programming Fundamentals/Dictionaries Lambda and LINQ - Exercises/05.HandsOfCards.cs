using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<int, HashSet<int>>>();
            string input = Console.ReadLine();
            char[] separators = { ':', ',' };

            while (input != "JOKER")
            {
                string[] hand = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string name = hand[0];

                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new Dictionary<int, HashSet<int>>());
                    for (int i = 1; i <= 4; i++)
                    {
                        dict[name].Add(i, new HashSet<int>());
                    }
                }
                for (int i = 1; i < hand.Length; i++)
                {
                    string currentCard = hand[i].Trim();
                    int face = 0;
                    int suite = 0;

                    if (currentCard.Length > 2)
                    {
                        face = GetFace(currentCard.Substring(0, 2));
                        suite = GetSuite(currentCard.Substring(2));
                    }
                    else
                    {
                        face = GetFace(currentCard[0].ToString());
                        suite = GetSuite(currentCard[1].ToString());
                    }
                    if (!dict[name][suite].Contains(face))                  
                        dict[name][suite].Add(face);                    
                }
                input = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                int sum = 0;
                foreach (var inside in item.Value)
                {
                    sum += inside.Key * inside.Value.Sum();
                }
                Console.WriteLine($"{item.Key}: {sum}");
            }
        }
        static int GetSuite(string suite)
        {
            switch (suite)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 0;
            }
        }
        static int GetFace(string face)
        {
            switch (face)
            {
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return int.Parse(face);
            }
        }
    }
}