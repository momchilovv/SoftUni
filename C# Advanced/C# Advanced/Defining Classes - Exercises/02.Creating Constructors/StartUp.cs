namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            Person firstPerson = new Person();

            Person secondPerson = new Person(20);

            Person thirdPerson = new Person("Pesho", 22);
        }
    }
}