using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string pattern = @"\@([A-Za-z]*)[^\@\-\!\:\>]*?\:([0-9]+)[^\@\-\!\:\>]*?\!([A?D])\![^\@\-\!\:\>]*?\-\>[^\@\-\!\:\>]*?([0-9]+)";

        List<string> decryptedMessages = new List<string>();
        List<string> destroyed = new List<string>();
        List<string> attacked = new List<string>();

        int messages = int.Parse(Console.ReadLine());

        for (int i = 0; i < messages; i++)
        {
            string message = Console.ReadLine();
            string decryptedMessage = string.Empty;
            int starCount = 0;

            foreach (var ch in message.ToLower())
            {
                if (ch == 's' || ch == 't' || ch == 'a' || ch == 'r')
                {
                    starCount++;
                }
            }

            foreach (var ch in message)
            {
                decryptedMessage += (char)(ch - starCount);
            }
            decryptedMessages.Add(decryptedMessage);
        }

        foreach (var item in decryptedMessages)
        {
            if (Regex.IsMatch(item, pattern))
            {
                Match match = Regex.Match(item, pattern);

                string planetName = match.Groups[1].Value;
                string type = match.Groups[3].Value;

                if (type == "A")
                {
                    attacked.Add(planetName);
                }
                if (type == "D")
                {
                    destroyed.Add(planetName);
                }
            }
        }

        Console.WriteLine($"Attacked planets: {attacked.Count}");
        if (attacked.Count > 0)
        {
            foreach (var planet in attacked.OrderBy(n => n))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        Console.WriteLine($"Destroyed planets: {destroyed.Count}");
        if (destroyed.Count > 0)
        {
            foreach (var planet in destroyed.OrderBy(n => n))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}