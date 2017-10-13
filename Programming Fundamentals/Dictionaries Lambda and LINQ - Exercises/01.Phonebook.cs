using System;
using System.Collections.Generic;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            var input = Console.ReadLine();
            var splitted = input.Split();
            var command = splitted[0];

            while (command != "END")
            {
                if (command == "A")
                {
                    if (phonebook.ContainsKey(splitted[1]))
                    {
                        phonebook[splitted[1]] = splitted[2];
                    }
                    else
                    {
                        phonebook.Add(splitted[1], splitted[2]);
                    }
                }
                else if (command == "S")
                {
                    if (phonebook.ContainsKey(splitted[1]))
                    {
                        Console.WriteLine($"{splitted[1]} -> {phonebook[splitted[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {splitted[1]} does not exist.");
                    }
                }
                input = Console.ReadLine();
                splitted = input.Split();
                command = splitted[0];
            }
        }
    }
}