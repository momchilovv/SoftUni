using System;
using System.IO;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\Files\Input.txt");
            for (int i = 1; i < lines.Length; i++)
            {
                File.AppendAllText("Output.txt", $"{i}.  " + lines[i] + Environment.NewLine);
            }
        }
    }
}