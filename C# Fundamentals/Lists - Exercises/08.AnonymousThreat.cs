using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> input = Console.ReadLine().Split().ToList();

        string[] command = Console.ReadLine().Split();

        while (command[0] != "3:1")
        {
            if (command[0] == "merge")
            {
                int startIndex = int.Parse(command[1]), endIndex = int.Parse(command[2]);
                if (startIndex < 0)
                {
                    startIndex = 0;
                }
                if (endIndex >= input.Count)
                {
                    endIndex = input.Count - 1;
                }
                for (int i = 0; i < input.Count; i++)
                {
                    if (i == startIndex)
                    {
                        for (int j = startIndex + 1; j <= endIndex; j++)
                        {
                            input[startIndex] += input[startIndex + 1];
                            input.RemoveAt(startIndex + 1);
                        }
                    }
                }
            }
            else if (command[0] == "divide")
            {
                int index = int.Parse(command[1]), partitions = int.Parse(command[2]);
                List<string> splitted = new List<string>();
                string word = input[index];
                int parts = word.Length / partitions;
                input.RemoveAt(index);

                for (int i = 0; i < partitions; i++)
                {
                    if (i == partitions - 1)
                    {
                        splitted.Add(word.Substring(i * parts));
                    }
                    else
                    {
                        splitted.Add(word.Substring(i * parts, parts));
                    }
                }
                input.InsertRange(index, splitted);
            }
            command = Console.ReadLine().Split();
        }
        Console.WriteLine(string.Join(" ", input));
    }
}