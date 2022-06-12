using System;

class Program
{
    static void Main(string[] args)
    {
        string dataType = Console.ReadLine();
        string input = Console.ReadLine();

        if (dataType == "int")
        {
            Console.WriteLine(GetDataType(int.Parse(input)));
        }
        else if (dataType == "real")
        {
            Console.WriteLine($"{GetDataType(double.Parse(input)):f2}");
        }
        else if (dataType == "string")
        {
            Console.WriteLine(GetDataType(input));
        }
    }
    public static int GetDataType(int number)
    {
        return number * 2;   
    }
    public static double GetDataType(double number)
    {
        return number * 1.5;
    }
    public static string GetDataType(string text)
    {
        return string.Format($"${text}$");
    }
}