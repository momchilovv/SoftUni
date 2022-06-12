using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        while (input != "END")
        {
            Console.WriteLine(IsPalindrome(int.Parse(input)).ToString().ToLower());
            input = Console.ReadLine();
        }
    }
    public static bool IsPalindrome (int number)
    {
        int temp = number;
        int reversed = 0;

        while (temp > 0)
        {
            reversed = reversed * 10 + temp % 10;
            temp /= 10;
        }
        return reversed == number;
    }
}