namespace Stealer
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var spy = new Spy();

            var result = spy.CollectGettersAndSetter("Stealer.Hacker");

            Console.WriteLine(result);
        }
    }
}