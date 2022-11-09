using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IIdentifiable identifiable;

            List<IIdentifiable> inhabitants = new List<IIdentifiable>();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                if (command.Length == 2)
                {
                    identifiable = new Robot(command[0], command[1]);
                    inhabitants.Add(identifiable);
                }
                if (command.Length == 3)
                {
                    identifiable = new Citizen(command[0], int.Parse(command[1]), command[2]);
                    inhabitants.Add(identifiable);
                }

                command = Console.ReadLine().Split();
            }

            string lastChars = Console.ReadLine();

            foreach (var inhabitant in inhabitants)
            {
                if (inhabitant.Id.EndsWith(lastChars))
                {
                    Console.WriteLine(inhabitant.Id);
                }
            }
        }
    }
}