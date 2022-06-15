using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        bool hasChanges = false;

        string[] command = Console.ReadLine().Split();

        while (command[0] != "end")
        {
            if (command[0] == "Add")
            {
                numbers.Add(int.Parse(command[1]));
                hasChanges = true;
            }
            else if (command[0] == "Remove")
            {
                numbers.Remove(int.Parse(command[1]));
                hasChanges = true;
            }
            else if (command[0] == "RemoveAt")
            {
                numbers.RemoveAt(int.Parse(command[1]));
                hasChanges = true;
            }
            else if (command[0] == "Insert")
            {
                numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                hasChanges = true;
            }
            else if (command[0] == "Contains")
            {
                if (numbers.Contains(int.Parse(command[1])))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No such number");
                }
            }
            else if (command[0] == "PrintEven")
            {
                foreach (var number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        Console.Write($"{number} ");
                    }
                }
                Console.WriteLine();
            }
            else if (command[0] == "PrintOdd")
            {
                foreach (var number in numbers)
                {
                    if (number % 2 == 1)
                    {
                        Console.Write($"{number} ");
                    }
                }
                Console.WriteLine();
            }
            else if (command[0] == "GetSum")
            {
                Console.WriteLine(numbers.Sum());
            }
            else if (command[0] == "Filter")
            {
                switch (command[1])
                {
                    case "<":
                        foreach (var number in numbers)
                        {
                            if (number < int.Parse(command[2]))
                            {
                                Console.Write($"{number} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "<=":
                        foreach (var number in numbers)
                        {
                            if (number <= int.Parse(command[2]))
                            {
                                Console.Write($"{number} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case ">":
                        foreach (var number in numbers)
                        {
                            if (number > int.Parse(command[2]))
                            {
                                Console.Write($"{number} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case ">=":
                        foreach (var number in numbers)
                        {
                            if (number >= int.Parse(command[2]))
                            {
                                Console.Write($"{number} ");
                            }
                        }
                        Console.WriteLine();
                        break;
                }
            }
            command = Console.ReadLine().Split();
        }
        if (hasChanges)
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}