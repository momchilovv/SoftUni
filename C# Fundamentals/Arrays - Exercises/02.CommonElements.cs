using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] firstArray = Console.ReadLine().Split();
        string[] secondArray = Console.ReadLine().Split();
        List<string> result = new List<string>();

        foreach (var item in secondArray)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (item == firstArray[i])
                {
                    result.Add(item);
                }
            }
        }
        Console.WriteLine(string.Join(" ", result));
    }
}