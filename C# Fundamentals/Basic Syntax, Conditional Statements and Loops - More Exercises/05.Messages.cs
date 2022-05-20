using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int letters = int.Parse(Console.ReadLine());
        string message = null;

        for (int i = 1; i <= letters; i++)
        {
            string input = Console.ReadLine();
            int mainDigit = input[0] - 48;
            int offset = (mainDigit - 2) * 3;

            if (mainDigit == 0)
            {
                message += ' ';
                continue;
            }
            if (mainDigit == 8 || mainDigit == 9)
            {
                offset++;
            }

            int letterIndex = offset + input.Length - 1;

            message += (char)(letterIndex + 97);
        }
        Console.WriteLine(message);
    }
}