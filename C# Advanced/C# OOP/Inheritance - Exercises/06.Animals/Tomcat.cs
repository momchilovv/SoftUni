namespace Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, gender: "Male") { }
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}