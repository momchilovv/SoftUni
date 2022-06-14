using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string[] command = Console.ReadLine().Split();

        while (command[0] != "end")
        {
            if (command[0] == "swap")
            {
                int temp = array[int.Parse(command[1])];
                array[int.Parse(command[1])] = array[int.Parse(command[2])];
                array[int.Parse(command[2])] = temp;
            }
            else if (command[0] == "multiply")
            {
                array[int.Parse(command[1])] *= array[int.Parse(command[2])];
            }
            else if (command[0] == "decrease")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i]--;
                }
            }
            command = Console.ReadLine().Split();
        }
        Console.WriteLine(string.Join(", ", array));
    }
}