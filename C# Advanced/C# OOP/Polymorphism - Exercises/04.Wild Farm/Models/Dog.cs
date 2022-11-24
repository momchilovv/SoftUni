namespace WildFarm.Models
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion) { }

        public override string AskForFood()
        {
            return $"Woof!";
        }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
        public override void GiveFood(Food food)
        {
            string type = food.GetType().Name;

            if (type == "Meat")
            {
                Weight += food.Quantity * 0.40;
                FoodEaten += food.Quantity;
            }
            else
            {
                System.Console.WriteLine($"{GetType().Name} does not eat {type}!");
            }
        }
    }
}