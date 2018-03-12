public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.Height = height;
        this.Width = width;
    }
    public double Height
    {
        get { return height; }
        private set { height = value; }
    }
    public double Width
    {
        get { return width; }
        private set { width = value; }
    }
    public override double CalculatePerimeter()
    {
        return 2 * this.Width + 2 * this.Height;
    }
    public override double CalculateArea()
    {
        return this.Height * this.Width;
    }
    public override string Draw()
    {
        return base.Draw() + this.GetType().Name;
    }
}