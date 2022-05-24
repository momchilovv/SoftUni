using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int openingBrackets = 0, closingBrackets = 0;

        for (int i = 0; i < number; i++)
        {
            string[] input = Console.ReadLine().Split();

            if (input[0] == "(")
            {
                openingBrackets++;
            }
            else if (input[0] == ")")
            {
                closingBrackets++;
                if (openingBrackets - closingBrackets != 0)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
        }
        if (openingBrackets == closingBrackets)
        {
            Console.WriteLine("BALANCED");
        }
        else
        {
            Console.WriteLine("UNBALANCED");
        }
    }
}