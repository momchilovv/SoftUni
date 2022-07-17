using System;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        string firstString = input[0], secondString = input[1];
        int sum = 0;

        int largestString;

        if (firstString.Length > secondString.Length)
        {
            largestString = firstString.Length;
        }
        else
        {
            largestString = secondString.Length;
        }
        for (int i = 0; i < largestString; i++)
        {
            if (i > firstString.Length - 1)
            {
                sum += secondString[i];
            }
            else if (i > secondString.Length - 1)
            {
                sum += firstString[i];
            }
            else
            {
                sum += firstString[i] * secondString[i];
            }
        }
        Console.WriteLine(sum);
    }
}