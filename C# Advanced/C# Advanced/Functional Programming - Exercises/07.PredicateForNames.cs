using System;

internal class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());

        string[] names = Console.ReadLine().Split();

        Func<string, bool> getLength = name => name.Length <= number;

        foreach (var name in names)
        {
            if (getLength(name))
            {
                Console.WriteLine(name);
            }
        }
    }
}