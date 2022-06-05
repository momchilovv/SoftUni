using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] result = null;
        int currentCount = 1, longestCount = 0;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                currentCount++;
                if (currentCount > longestCount)
                {
                    longestCount = currentCount;
                    result = new int[longestCount];
                    for (int j = 0; j < longestCount; j++)
                    {
                        result[j] = array[i];
                    }
                }
            }
            else
            {
                currentCount = 1;
            }         
        }
        Console.WriteLine(string.Join(" ", result));
    }
}