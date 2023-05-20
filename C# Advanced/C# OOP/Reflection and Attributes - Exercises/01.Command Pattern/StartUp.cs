using CommandPattern.Core;

namespace CommandPattern
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var command = new CommandInterpreter();
            var engine = new Engine(command);

            engine.Run();
        }
    }
}
