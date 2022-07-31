using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        int key = int.Parse(Console.ReadLine());

        string pattern = @"\@([A-Za-z]*)[^\@\-\!\:\>]*\![G]\!";
        List<string> goodKids = new List<string>();

        string input = Console.ReadLine();

        while (input != "end")
        {
            StringBuilder decrypted = new StringBuilder();

            foreach (var ch in input)
            {
                decrypted.Append((char)(ch - key));
            }

            Match match = Regex.Match(decrypted.ToString(), pattern);

            if (match.Success)
            {
                goodKids.Add(match.Groups[1].Value);
            }

            input = Console.ReadLine();
        }
        Console.WriteLine(string.Join("\r\n", goodKids));
    }
}