using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        int[] result;
        int[] len = new int[array.Length];
        int[] prev = new int[array.Length];
        int maxLength = 0, index = -1;

        for (int i = 0; i < array.Length; i++)
        {
            len[i] = 1;
            prev[i] = -1;

            for (int j = 0; j < i; j++)
            {
                if (array[j] < array[i] && len[j] >= len[i])
                {
                    len[i] = len[j] + 1;
                    prev[i] = j;
                }
            }
            if (len[i] > maxLength)
            {
                maxLength = len[i];
                index = i;
            }
        }
        
        result = new int[maxLength];
        for (int i = 0; i < maxLength; i++)
        {
            result[i] = array[index];
            index = prev[index];
        }

        Console.WriteLine(string.Join(" ", result.Reverse()));
    }
}