using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string message = Console.ReadLine();
        string[] command = Console.ReadLine().Split("|");

        while (command[0] != "Decode")
        {
            if (command[0] == "ChangeAll")
            {
                message = message.Replace(char.Parse(command[1]), char.Parse(command[2]));
            }
            else if (command[0] == "Insert")
            {
                message = message.Insert(int.Parse(command[1]), command[2]);
            }
            else if (command[0] == "Move")
            {
                message = message.Remove(0, int.Parse(command[1])) + message.Substring(0, int.Parse(command[1]));
            }
            command = Console.ReadLine().Split("|");
        }
        Console.WriteLine($"The decrypted message is: {message}");
    }
}