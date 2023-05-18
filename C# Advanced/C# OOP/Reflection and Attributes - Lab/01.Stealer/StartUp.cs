namespace Stealer
{
    public class Startup
    {
        public static void Main()
        {
            var spy = new Spy();

            var result = spy.StealFieldInfo("Stealer.Hacker", "username", "password");

            Console.WriteLine(result);
        }
    }
}