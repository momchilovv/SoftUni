using System;

public abstract class Tyre
{
    private double degradation;
    
    public string Name { get; }
    public double Hardness { get; }
    public virtual double Degradation
    {
        get
        {
            return this.degradation;
        }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException(OutputMessages.BlownTyre);
            }
            this.degradation = value;
        }
    }

    protected Tyre(string name, double hardness)
    {
        this.Name = name;
        this.Hardness = hardness;
        this.degradation = 100;
    }

    public virtual void CompleteLap()
    {
        this.Degradation -= this.Hardness;
    }
}