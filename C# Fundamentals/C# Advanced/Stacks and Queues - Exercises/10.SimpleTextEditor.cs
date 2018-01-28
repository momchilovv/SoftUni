using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            stack.Push("");

            for (int i = 0; i < input; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "1")
                {
                    string newText = stack.Peek() + command[1];
                    stack.Push(newText);
                }
                else if (command[0] == "2")
                {
                    string previous = stack.Peek();
                    string cuttedText = previous.Substring(0, previous.Length - int.Parse(command[1]));
                    stack.Push(cuttedText);
                }
                else if (command[0] == "3")
                {
                    string text = stack.Peek();
                    Console.WriteLine(text[int.Parse(command[1]) - 1]);
                }
                else if (command[0] == "4")
                {
                    stack.Pop();
                }
            }
        }
    }
}