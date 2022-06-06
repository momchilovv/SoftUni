using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int times = int.Parse(Console.ReadLine());

        Console.WriteLine(Repeat(input, times));
    }
    public static string Repeat(string input, int times)
    {
        string result = input;
        for (int i = 1; i < times; i++)
        {
            result += input;
        }
        return result;
    }
}