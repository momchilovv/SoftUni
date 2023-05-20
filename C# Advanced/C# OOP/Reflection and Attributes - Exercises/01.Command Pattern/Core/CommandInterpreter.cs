using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            var input = args.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var commandName = input[0] + "Command";

            string[] commandArgs = input.Skip(1).ToArray();

            var assembly = Assembly.GetCallingAssembly();
            var types = assembly.GetTypes();

            var type = types.FirstOrDefault(t => t.Name == commandName);

            if (type == null)
            {
                return "Invalid command.";
            }

            var instance = Activator.CreateInstance(type);
            var command = (ICommand)instance;

            string result = command.Execute(commandArgs);

            return result;
        }
    }
}