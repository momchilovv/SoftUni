using System;
using System.Linq;

namespace _01.RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            string[] rotatedArray = new string[input.Length];

            for (int i = 0; i < input.Length - 1; i++)
            {
                rotatedArray[i + 1] = input[i];
            }
            string lastElement = input[rotatedArray.Length - 1];
            rotatedArray[0] = lastElement;

            Console.WriteLine(string.Join(" ", rotatedArray));
        }
    }
}