using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();

            while (!input.Equals("3:1"))
            {
                string[] commands = input.Split();
                string command = commands[0];
                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);

                if (startIndex < 0 || startIndex > elements.Count -1)
                {
                    startIndex = 0;
                }
                if (endIndex < 0 || endIndex > elements.Count - 1)
                {
                    endIndex = elements.Count - 1;
                }

                switch (command)
                {
                    case "merge":
                        var concat = "";
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            concat += elements[i];
                        }

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            elements.RemoveAt(startIndex);
                        }

                        elements.Insert(startIndex, concat);
                        break;

                    case "divide":
                        int startIndexDivide = int.Parse(commands[1]);
                        int partitions = int.Parse(commands[2]);
                        
                        List<string> result = DivideEqual(elements[startIndexDivide], partitions);

                        elements.RemoveAt(startIndexDivide);
                        elements.InsertRange(startIndexDivide, result);
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", elements));
        }
        static List<string> DivideEqual(string word, int divide)
        {
            List<string> result = new List<string>();

            int partitionsCount = word.Length / divide;

            while (word.Length >= partitionsCount)
            {
                string element = word.Substring(0, partitionsCount);
                result.Add(element);
                word = word.Substring(partitionsCount);              
            }
            result.Add(word);
            if (result.Count == divide)
            {
                return result;
            }
            else
            {
                string concat = "";
                concat += result[result.Count - 2];
                concat += result[result.Count - 1];

                result.Remove(result[result.Count - 1]);
                result.Remove(result[result.Count - 1]);

                result.Add(concat);
                
                return result;
            }
        }
    }
}