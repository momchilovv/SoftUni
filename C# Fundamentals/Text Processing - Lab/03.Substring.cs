using System;

class Program
{
    static void Main(string[] args)
    {
        string remove = Console.ReadLine();
        string input = Console.ReadLine();

        while (input.Contains(remove))
        {
            int index = input.IndexOf(remove);

             input = input.Remove(index, remove.Length);
        }
        Console.WriteLine(input);
    }
}