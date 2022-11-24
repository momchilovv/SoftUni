using WildFarm.Models;

namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize) { }

        public override string AskForFood()
        {
            return "Hoot Hoot";
        }
        public override void GiveFood(Food food)
        {
            string type = food.GetType().Name;

            if (type == "Meat")
            {
                Weight += food.Quantity * 0.25;
                FoodEaten += food.Quantity;
            }
            else
            {
                System.Console.WriteLine($"{GetType().Name} does not eat {type}!");
            }
        }
    }
}