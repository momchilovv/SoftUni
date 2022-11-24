namespace WildFarm.Models
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed) { }

        public override string AskForFood()
        {
            return "Meow";
        }
        public override void GiveFood(Food food)
        {
            string type = food.GetType().Name;

            if (type == "Vegetable" || type == "Meat")
            {
                Weight += food.Quantity * 0.30;
                FoodEaten += food.Quantity;
            }
            else
            {
                System.Console.WriteLine($"{GetType().Name} does not eat {type}!");
            }
        }
    }
}