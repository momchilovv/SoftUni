using System;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' });

            Random rnd = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                int pos1 = rnd.Next(0, input.Length);
                int pos2 = rnd.Next(0, input.Length);

                var change = input[pos1];
                input[pos1] = input[pos2];
                input[pos2] = change;
            }
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}