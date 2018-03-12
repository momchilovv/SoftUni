using System;

public class Animal
{
    public string Name { get; protected set; }
    public string FavouriteFood { get; set; }

    protected Animal(string name, string favouriteFood)
    {
        this.Name = name;
        this.FavouriteFood = favouriteFood;
    }
    public virtual string ExplainSelf()
    {
        return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
    }
}
public class Cat : Animal
{
    public Cat(string name, string favouriteFood) : base(name, favouriteFood)
    {
    }
    public override string ExplainSelf()
    {
        return base.ExplainSelf() + Environment.NewLine + "MEEOW";
    }
}
public class Dog : Animal
{
    public Dog(string name, string favouriteFood) : base(name, favouriteFood)
    {
    }
    public override string ExplainSelf()
    {
        return base.ExplainSelf() + Environment.NewLine + "DJAAF";
    }
}