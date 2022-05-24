using System;

class Program
{
    static void Main(string[] args)
    {
        int key = int.Parse(Console.ReadLine());
        int letters = int.Parse(Console.ReadLine());
        string message = null;

        for (int i = 0; i < letters; i++)
        {
            char letter = char.Parse(Console.ReadLine());

            message += (char)(letter + key);
        }
        Console.WriteLine(message.ToString());
    }
}