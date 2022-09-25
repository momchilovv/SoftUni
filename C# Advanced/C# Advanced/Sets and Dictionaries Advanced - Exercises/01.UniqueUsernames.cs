using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        var usernames = new HashSet<string>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            usernames.Add(Console.ReadLine());
        }

        Console.WriteLine(String.Join("\r\n", usernames));
    }
}