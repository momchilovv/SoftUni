using System;

class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();

        if (type == "int")
        {
            GetMax(int.Parse(firstInput), int.Parse(secondInput));
        }
        else if (type == "char")
        {
            GetMax(char.Parse(firstInput), char.Parse(secondInput));
        }
        else
        {
            GetMax(firstInput, secondInput);
        }
    }
    public static void GetMax(string firstString, string secondString)
    {
        if (firstString.CompareTo(secondString) > 1)
        {
            Console.WriteLine(firstString);
        }
        else
        {
            Console.WriteLine(secondString);
        }
    }
    public static void GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber >= secondNumber)
        {
            Console.WriteLine(firstNumber);
        }
        else
        {
            Console.WriteLine(secondNumber);
        }
    }
    public static void GetMax(char firstCharacter, char secondCharacter)
    {
        if (firstCharacter >= secondCharacter)
        {
            Console.WriteLine(firstCharacter);
        }
        else
        {
            Console.WriteLine(secondCharacter);
        }
    }
}