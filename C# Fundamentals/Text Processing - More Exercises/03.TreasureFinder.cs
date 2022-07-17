using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();

        string message = Console.ReadLine();

        while (message != "find")
        {
            string decryptedMessage = string.Empty;
            int count = 0;

            foreach (var ch in message)
            {
                decryptedMessage += (char)(ch - key[count]);

                count++;
                if (count % key.Length == 0)
                {
                    count = 0;
                }
            }

            string[] treasure = decryptedMessage.Split("&");
            string coordinates = decryptedMessage.Substring(decryptedMessage.IndexOf('<') + 1,
                decryptedMessage.IndexOf('>') - decryptedMessage.IndexOf('<') - 1);

            Console.WriteLine($"Found {treasure[1]} at {coordinates}");

            message = Console.ReadLine();
        }
    }
}