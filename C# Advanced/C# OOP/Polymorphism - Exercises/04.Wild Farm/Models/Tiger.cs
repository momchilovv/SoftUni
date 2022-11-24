namespace WildFarm.Models
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed) { }

        public override string AskForFood()
        {
            return "ROAR!!!";
        }

        public override void GiveFood(Food food)
        {
            string type = food.GetType().Name;

            if (type == "Meat")
            {
                Weight += food.Quantity;
                FoodEaten += food.Quantity;
            }
            else
            {
                System.Console.WriteLine($"{GetType().Name} does not eat {type}!");
            }
        }
    }
}