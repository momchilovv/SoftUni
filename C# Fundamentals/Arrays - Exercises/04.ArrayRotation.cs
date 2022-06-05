using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rotation = int.Parse(Console.ReadLine());

        for (int i = 0; i < rotation; i++)
        {
            int rotatedElement = array[0];
            for (int j = 0; j < array.Length - 1; j++)
            {
                array[j] = array[j + 1];
            }
            array[array.Length - 1] = rotatedElement;
        }
        Console.WriteLine(string.Join(" ", array));
    }
}