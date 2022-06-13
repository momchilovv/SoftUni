using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string[] command = Console.ReadLine().Split();

        while (command[0] != "end")
        {
            if (command[0] == "exchange")
            {
                Exchange(array, int.Parse(command[1]));
            }
            else if (command[0] == "max")
            {
                if (command[1] == "even")
                {
                    MaxEven(array);
                }
                else
                {
                    MaxOdd(array);
                }
            }
            else if (command[0] == "min")
            {
                if (command[1] == "even")
                {
                    MinEven(array);
                }
                else
                {
                    MinOdd(array);
                }
            }
            else if (command[0] == "first")
            {
                FirstCount(array, int.Parse(command[1]), command[2]);
            }
            else if (command[0] == "last")
            {
                LastCount(array, int.Parse(command[1]), command[2]);
            }
            command = Console.ReadLine().Split();
        }
        Console.Write("[");
        Console.Write(string.Join(", ", array));
        Console.WriteLine("]");
    }
    public static void LastCount(int[] array, int count, string type)
    {
        List<int> result = new List<int>();
        int counter = 0;

        if (count > array.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }
        if (type == "even")
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                if (array[i] % 2 == 0)
                {
                    result.Add(array[i]);
                    counter++;
                }
                if (counter == count)
                {
                    break;
                }
            }
        }
        else if (type == "odd")
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] % 2 == 1)
                {
                    result.Add(array[i]);
                    counter++;
                }
                if (counter == count)
                {
                    break;
                }
            }
        }
        if (result.Count == 0)
        {
            Console.WriteLine("[]");
        }
        else
        {
            result.Reverse();
            Console.Write("[");
            Console.Write(string.Join(", ", result));
            Console.WriteLine("]");
        }
    }
    public static void FirstCount(int[] array, int count, string type)
    {
        List<int> result = new List<int>();
        int counter = 0;

        if (count > array.Length)
        {
            Console.WriteLine("Invalid count");
            return;
        }
        if (type == "even")
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    result.Add(array[i]);
                    counter++;
                }
                if (counter == count)
                {
                    break;
                }
            }
        }
        else if (type == "odd")
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    result.Add(array[i]);
                    counter++;
                }
                if (counter == count)
                {
                    break;
                }
            }
        }
        if (result.Count == 0)
        {
            Console.WriteLine("[]");
        }
        else
        {
            Console.Write("[");
            Console.Write(string.Join(", ", result));
            Console.WriteLine("]");
        }
    }
    public static void MaxEven(int[] array)
    {
        int biggest = int.MinValue, index = 0;
        bool containsEven = false;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                containsEven = true;
                if (array[i] >= biggest)
                {
                    biggest = array[i];
                    index = i;
                }
            }
        }
        if (containsEven)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
    public static void MaxOdd(int[] array)
    {
        int biggest = int.MinValue, index = 0;
        bool containsOdd = false;

        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i]) % 2 == 1)
            {
                containsOdd = true;
                if (array[i] >= biggest)
                {
                    biggest = array[i];
                    index = i;
                }
            }
        }
        if (containsOdd)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
    public static void MinEven(int[] array)
    {
        int smallest = int.MaxValue, index = 0;
        bool containsEven = false;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                containsEven = true;
                if (array[i] <= smallest)
                {
                    smallest = array[i];
                    index = i;
                }
            }
        }
        if (containsEven)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
    public static void MinOdd(int[] array)
    {
        int smallest = int.MaxValue, index = 0;
        bool containsOdd = false;

        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i]) % 2 == 1)
            {
                containsOdd = true;
                if (array[i] <= smallest)
                {
                    smallest = array[i];
                    index = i;
                }
            }
        }
        if (containsOdd)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("No matches");
        }
    }
    public static void Exchange(int[] array, int index)
    {
        if (index < 0 || index > array.Length - 1)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            for (int i = 0; i <= index; i++)
            {
                int currentNumber = array[0];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = currentNumber;
            }
        }
    }
}