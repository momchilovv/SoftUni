using System;
using System.IO;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"..\Files\Input.txt");
            for (int i = 1; i < lines.Length; i += 2)
            {
                File.AppendAllText("Output.txt", lines[i] + Environment.NewLine);
            }
        }
    }
}