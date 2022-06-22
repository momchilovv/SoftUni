using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> indexes = Console.ReadLine().Split().ToList();
        string text = Console.ReadLine(), output = null;

        for (int i = 0; i < indexes.Count; i++)
        {
            int sum = 0, number = int.Parse(indexes[i]), currentNumber = 0;
            while (number > 0)
            {
                currentNumber = number % 10;
                sum += currentNumber;
                number /= 10;
            }
            for (int j = 0; j < text.Length; j++)
            {
                if (sum > text.Length)
                {
                    sum -= text.Length;
                }
                if (sum == j)
                {
                    output += text[j];
                    text = text.Remove(j, 1);
                }
            }
        }
        Console.WriteLine(output);
    }
}