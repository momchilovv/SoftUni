using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> validUsernames = new List<string>();
        string[] usernames = Console.ReadLine().Split(", ");
        bool isValid = false;

        foreach (var username in usernames)
        {
            if (username.Length >= 3 && username.Length <= 16)
            {
                foreach (var ch in username)
                {
                    if (char.IsLetterOrDigit(ch) || ch == '-' || ch == '_')
                    {
                        isValid = true;
                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    validUsernames.Add(username);
                }
            }          
        }
        Console.WriteLine(string.Join("\r\n", validUsernames));
    }
}