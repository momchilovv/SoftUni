using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int numbers = int.Parse(Console.ReadLine());
        int[] firstArray = new int[numbers];
        int[] secondArray = new int[numbers];

        for (int i = 0; i < numbers; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (i % 2 == 0)
            {
                firstArray[i] = input[0];
                secondArray[i] = input[1];
            }
            else
            {
                firstArray[i] = input[1];
                secondArray[i] = input[0];
            }
        }
        Console.WriteLine(string.Join(" ", firstArray));
        Console.WriteLine(string.Join(" ", secondArray));
    }
}