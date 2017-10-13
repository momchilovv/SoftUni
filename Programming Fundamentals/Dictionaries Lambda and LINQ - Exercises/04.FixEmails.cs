using System;
using System.Collections.Generic;

namespace _04.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emails = new Dictionary<string, string>();
            var name = Console.ReadLine();
            while (name != "stop")
            {
                var email = Console.ReadLine();
                if (email == "stop")
                {
                    break;
                }
                if (!(email.EndsWith("uk") || email.EndsWith("us")))
                {
                    emails.Add(name, email);
                }
                else
                {
                    name = Console.ReadLine();
                    continue;
                }
                name = Console.ReadLine();
            }
            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}