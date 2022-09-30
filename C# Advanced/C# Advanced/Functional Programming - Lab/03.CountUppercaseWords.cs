using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        Func<string, bool> isUpper = word => char.IsUpper(word[0]);
        Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(isUpper).ToList().ForEach(w => Console.WriteLine(w));
    }
}