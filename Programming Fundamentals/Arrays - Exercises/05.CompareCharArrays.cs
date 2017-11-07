using System;
using System.Linq;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] first = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] second = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int minLen = Math.Min(first.Length, second.Length);
            for (int i = 0; i < minLen; i++)
            {
                if (first[i] < second[i])
                {
                    foreach (char ch in first)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();

                    foreach (char ch in second)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();
                    return;
                }
                else if (second[i] < first[i])
                {
                    foreach (char ch in second)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();

                    foreach (char ch in first)
                    {
                        Console.Write(ch);
                    }
                    Console.WriteLine();
                    return;
                }
            }
            if (first.Length < second.Length)
            {
                Console.WriteLine(new string(first));
                Console.WriteLine(new string(second));
            }
            else
            {
                Console.WriteLine(new string(second));
                Console.WriteLine(new string(first));
            }
        }
    }
}