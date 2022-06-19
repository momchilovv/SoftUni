using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        string[] command = Console.ReadLine().Split();

        while (command[0] != "end")
        {
            if (command[0] == "Delete")
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == int.Parse(command[1]))
                    {
                        numbers.Remove(numbers[i]);
                    }
                }
            }
            else if (command[0] == "Insert")
            {
                numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
            }
            command = Console.ReadLine().Split();
        }
        Console.WriteLine(string.Join(" ", numbers));
    }
}