using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string password = Console.ReadLine();
        
        if (CheckForDigits(password) == true && CheckPasswordLength(password) == true&& CheckForSpecialCharacters(password) == true)
        {
            Console.WriteLine("Password is valid");
        }
        if (!CheckPasswordLength(password))
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
        }
        if (!CheckForSpecialCharacters(password))
        {
            Console.WriteLine("Password must consist only of letters and digits");
        }
        if (!CheckForDigits(password))
        {
            Console.WriteLine("Password must have at least 2 digits");
        }       
    }
    public static bool CheckForSpecialCharacters(string password)
    {
        Regex regex = new Regex("^[a-zA-Z0-9 ]*$");

        if (!regex.IsMatch(password))
        {
            return false;
        }
        return true;
    }
    public static bool CheckForDigits(string password)
    {
        int digits = 0;

        foreach (var ch in password)
        {
            if (char.IsDigit(ch))
            {
                digits++;
            }
        }
        if (digits < 2)
        {
            return false;
        }
        return true;
    }
    public static bool CheckPasswordLength(string password)
    {
        if (password.Length < 6 || password.Length > 10)
        {
            return false;  
        }
        return true;
    }
}