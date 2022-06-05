using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int rightSum = 0, leftSum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            rightSum = 0;
            leftSum = 0;

            for (int j = i; j > 0; j--)
            {
                int nextElement = j - 1;
                if (j > 0)
                {
                    leftSum += array[nextElement];
                }
            }

            for (int k = i; k < array.Length; k++)
            {
                int nextElement = k + 1;
                if (k < array.Length - 1)
                {
                    rightSum += array[nextElement];
                }
            }

            if (rightSum == leftSum)
            {
                Console.WriteLine(i);
                Environment.Exit(0);
            }
        }
        Console.WriteLine("no");
    }
}