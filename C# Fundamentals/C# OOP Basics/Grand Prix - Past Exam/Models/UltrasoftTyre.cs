using System;

public class UltrasoftTyre : Tyre
{
    public double Grip { get; }

    public UltrasoftTyre(double hardness, double grip) : base("Ultrasoft", hardness) { this.Grip = grip; }

    public override double Degradation
    {
        get => base.Degradation;
        protected set
        {
            if(value < 30)
            {
                throw new ArgumentException(OutputMessages.BlownTyre);
            }
            base.Degradation = value;
        }
    }

    public override void CompleteLap()
    {
        base.CompleteLap();
        this.Degradation -= this.Grip;
    }
}