using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int index = 0;
        bool equal = true;

        if (firstArray.Length == secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    equal = false;
                    index = i;
                    break;
                }
            }
        }
        if (equal)
        {
            Console.WriteLine($"Arrays are identical. Sum: {firstArray.Sum()}");
        }
        else
        {
            Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
        }

    }
}