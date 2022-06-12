using System;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= number; i++)
        {
            if (IsDivisible(i) && CheckForOddDigit(i))
            {
                Console.WriteLine(i);
            }
        }
    }
    public static bool IsDivisible(int number)
    {
        int sum = 0;
        foreach (var item in number.ToString())
        {
            sum += item;
        }
        return sum % 8 == 0;
    }
    public static bool CheckForOddDigit(int number)
    {
        foreach (var item in number.ToString())
        {
            if (item % 2 == 1)
            {
                return true;
            }
        }
        return false;
    }
}