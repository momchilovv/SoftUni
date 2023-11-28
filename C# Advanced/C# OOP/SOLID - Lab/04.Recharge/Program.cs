namespace P04.Recharge
{
    class Program
    {
        static void Main()
        {
            Worker worker = new Worker("Pesho");

            Robot robot = new Robot("Ksiomii", 200);

            worker.Work(8);
            worker.Sleep();

            robot.Work(12);
            robot.Work(88);
            robot.Recharge();
        }
    }
}