using System;

class Program
{
    static void Main(string[] args)
    {
        int field = int.Parse(Console.ReadLine());

        int[] bugs = new int[field];

        string[] indexes = Console.ReadLine().Split();

        for (int i = 0; i < indexes.Length; i++)
        {
            int index = int.Parse(indexes[i]);
            if (index >= 0 && index < field)
            {
                bugs[index] = 1;
            }
        }
        string[] input = Console.ReadLine().Split();

        while (input[0] != "end")
        {
            bool isFirst = true;
            int index = int.Parse(input[0]);
           
            while (index >= 0 && index < field && bugs[index] != 0)
            {
                if (isFirst)
                {
                    bugs[index] = 0;
                    isFirst = false;
                }

                string direction = input[1];
                int flyLength = int.Parse(input[2]);
                if (direction == "left")
                {
                    index -= flyLength;
                    if (index >= 0 && index < field)
                    {
                        if (bugs[index] == 0)
                        {
                            bugs[index] = 1;
                            break;
                        }
                    }
                }
                else
                {
                    index += flyLength;
                    if (index >= 0 && index < field)
                    {
                        if (bugs[index] == 0)
                        {
                            bugs[index] = 1;
                            break;
                        }
                    }
                }
            }
            input = Console.ReadLine().Split();
        }
        Console.WriteLine(string.Join(" ", bugs));
    }
}