using P04.Recharge.Contracts;
using System;

namespace P04.Recharge
{
    public class Robot : Employee, IRechargeable
    {
        private int capacity;
        private int currentPower;
        private string id;
         
        public Robot(string id, int capacity) : base(id)
        {
            this.currentPower = capacity;
            this.capacity = capacity;
            this.id = id;
        }

        public int Capacity
        {
            get { return capacity; }
        }

        public int CurrentPower
        {
            get { return currentPower; }
            set { currentPower = value; } 
        }

        public override void Work(int hours)
        {
            if (hours > currentPower)
            {
                hours = currentPower;
            }

            currentPower -= hours;

            Console.WriteLine($"Robot {id} worked for {hours} hours.");
            Console.WriteLine($"Power left: ({currentPower}).");
        }

        public void Recharge()
        {
            currentPower = capacity;

            Console.WriteLine($"Robot {id} was recharged to maximum capacity ({capacity}).");
        }
    }
}