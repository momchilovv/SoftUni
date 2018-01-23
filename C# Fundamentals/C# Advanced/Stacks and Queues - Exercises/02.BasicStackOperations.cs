using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int s = input[1];
            int x = input[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (!stack.Contains(x))
            {
                int min = stack.Min();
                Console.WriteLine(min);
            }
        }
    }
}