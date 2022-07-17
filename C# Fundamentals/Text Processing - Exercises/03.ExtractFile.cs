using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split("\\");

        string path = input[input.Length - 1];

        string[] file = path.Split(".");

        Console.WriteLine($"File name: {file[0]}");
        Console.WriteLine($"File extension: {file[1]}");
    }
}