using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var input = Console.ReadLine();
            var splited = input.Split();
            var command = splited[0];

            while (!(input == "Even" || input == "Odd"))
            {
                if (command == "Delete")
                {
                    var element = int.Parse(splited[1]);
                    nums.Remove(element);
                    nums.Remove(element);
                }
                else if (command == "Insert")
                {
                    var element = int.Parse(splited[1]);
                    var position = int.Parse(splited[2]);
                    nums.Insert(position, element);
                    
                }
                input = Console.ReadLine();
                splited = input.Split();
                command = splited[0];
            }
            foreach (var num in nums)
            {
                if (input == "Even")
                {
                    if (num % 2 == 0)
                    {
                        Console.Write($"{num} ");
                    }
                }
                else if (input == "Odd")
                {
                    if (num % 2 == 1)
                    {
                        Console.Write($"{num} ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}