using System;
using P04.Recharge.Contracts;

namespace P04.Recharge
{
    public class Worker : Employee, ISleeper
    {
        private string id;
        private int workingHours;

        public Worker(string id) : base(id)
        {
            this.id = id;
        }

        public override void Work(int hours)
        {
            workingHours += hours;

            Console.WriteLine($"Worker {id} worked for {hours} hours.");
        }

        public void Sleep()
        {
            Console.WriteLine($"Worker {id} slept.");
        }
    }
}