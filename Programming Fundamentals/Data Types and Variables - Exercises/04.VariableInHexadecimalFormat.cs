using System;

namespace _04.VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var answer = Convert.ToInt32(input, 16);
            Console.WriteLine(answer);
        }
    }
}