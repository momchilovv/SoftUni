namespace WildFarm.Models
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion) { }

        public override string AskForFood()
        {
            return $"Squeak";
        }

        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }

        public override void GiveFood(Food food)
        {
            string type = food.GetType().Name;

            if (type == "Vegetable" || type == "Fruit")
            {
                Weight += food.Quantity * 0.10;
                FoodEaten += food.Quantity;
            }
            else
            {
                System.Console.WriteLine($"{GetType().Name} does not eat {type}!");
            }
        }
    }
}