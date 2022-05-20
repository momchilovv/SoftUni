using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string username = Console.ReadLine();
        char[] reversed = username.ToCharArray();

        foreach (var ch in reversed.Reverse())
        {
            Console.Write(ch);
        }
        Console.WriteLine();
    }
}