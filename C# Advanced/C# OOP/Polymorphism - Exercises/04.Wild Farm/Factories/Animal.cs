using WildFarm.Models;

namespace WildFarm
{
    public abstract class Animal
    {
        private int foodEaten = 0;

        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = foodEaten;
        }

        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public abstract string AskForFood();

        public abstract void GiveFood(Food food);
    }
}