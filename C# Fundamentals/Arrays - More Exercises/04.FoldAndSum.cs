using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<int> result = new List<int>();

        int firstRow = array.Length / 4;
        int secondRow = firstRow + (array.Length / 2);
        int sum = firstRow - 1;

        for (int i = firstRow; i < secondRow; i++)
        {
            result.Add(array[i] + array[sum]);
            sum--;
            if (sum < 0)
            {
                sum = array.Length - 1;
            }
        }
        Console.WriteLine(string.Join(" ", result));
    }
}