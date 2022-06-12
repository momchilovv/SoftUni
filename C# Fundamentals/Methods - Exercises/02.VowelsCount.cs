using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Console.WriteLine(VowelsCount(input));
    }
    public static int VowelsCount(string input)
    {
        int count = 0;
        foreach (var ch in input)
        {
            switch (ch)
            {
                case 'a':
                case 'A':
                    count++;
                    break;
                case 'e':
                case 'E':
                    count++;
                    break;
                case 'o':
                case 'O':
                    count++;
                    break;
                case 'i':
                case 'I':
                    count++;
                    break;
                case 'u':
                case 'U':
                    count++;
                    break;
            }
        }
        return count;
    }
}