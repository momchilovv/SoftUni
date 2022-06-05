using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        string[] plainText = new string[number];
        int[] encrypted = new int[number];
        int sumCode = 0;

        for (int i = 0; i < number; i++)
        {
            plainText[i] = Console.ReadLine();
        }
        for (int i = 0; i < plainText.Length; i++)
        {
            foreach (var ch in plainText[i])
            {
                if (IsVowel(ch))
                {
                    sumCode += ch * plainText[i].Length;
                }
                else
                {
                    sumCode += ch / plainText[i].Length;
                }
            }
            encrypted[i] = sumCode;
            sumCode = 0;
        }
        Console.WriteLine(string.Join("\r\n", encrypted.OrderBy(x => x)));
    }
    public static bool IsVowel(char ch)
    {
        switch (ch)
        {
            case 'a': 
            case 'A':
                return true;
            case 'e':
            case 'E':
                return true;
            case 'o':
            case 'O':
                return true;
            case 'i':
            case 'I':
                return true;
            case 'u':
            case 'U':
                return true;
            default:
                return false;
        }
    }
}