using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        StringBuilder stringBuilder = new StringBuilder();

        int explosion = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '>')
            {

                explosion += int.Parse(input[i + 1].ToString());

                stringBuilder.Append(input[i]);
            }
            else if (explosion == 0)
            {
                stringBuilder.Append(input[i]);
            }
            else
            {
                explosion--;
            }
        }
        Console.WriteLine(stringBuilder);
    }
}