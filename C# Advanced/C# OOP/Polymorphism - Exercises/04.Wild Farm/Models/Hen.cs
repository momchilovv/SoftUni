namespace WildFarm.Models
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize) { }

        public override string AskForFood()
        {
            return "Cluck";
        }

        public override void GiveFood(Food food)
        {
            string type = food.GetType().Name;

            Weight += food.Quantity * 0.35;
            FoodEaten += food.Quantity;
        }
    }
}