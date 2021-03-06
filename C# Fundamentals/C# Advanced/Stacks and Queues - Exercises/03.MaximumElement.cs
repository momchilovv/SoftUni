using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());
            int[] command;

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < queries; i++)
            {
                command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (command[0] == 1)
                {
                    stack.Push(command[1]);
                }
                else if (command[0] == 2)
                {
                    stack.Pop();
                }
                else if (command[0] == 3)
                {
                    int max = stack.Max();
                    Console.WriteLine(max);
                }
            }
        }
    }
}