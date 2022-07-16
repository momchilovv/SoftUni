using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        while (input != "end")
        {
            Console.WriteLine($"{input} = {string.Join("",input.Reverse())}");
            input = Console.ReadLine();
        }
    }
}