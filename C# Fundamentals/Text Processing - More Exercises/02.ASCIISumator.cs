using System;

class Program
{
    static void Main(string[] args)
    {
        char startChar = char.Parse(Console.ReadLine());
        char endChar = char.Parse(Console.ReadLine());

        string text = Console.ReadLine();

        double sum = 0;

        for (int i = startChar + 1; i < endChar; i++)
        {
            foreach (var ch in text)
            {
                if (ch == i)
                {
                    sum += i;
                }
            }
        }
        Console.WriteLine(sum);
    }
}