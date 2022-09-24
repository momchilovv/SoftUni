using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var names = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            names.Add(Console.ReadLine());
        }

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}