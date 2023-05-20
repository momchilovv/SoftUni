using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class ExitCommand : ICommand
    {
        public string Execute(string[] args)
        {
            System.Environment.Exit(0);
            return null;
        }
    }
}