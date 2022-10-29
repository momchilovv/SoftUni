namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        public Coffee(string name, double caffeine) : base(name, price: 3.50m, mililiters: 50) 
        { 
            Caffeine = caffeine; 
        }

        public double Caffeine { get; set; }
    }
}