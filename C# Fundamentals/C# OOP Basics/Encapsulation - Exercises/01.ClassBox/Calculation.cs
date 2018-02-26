public class Calculation
{
    private double length;
    private double width;
    private double height;

    public double Height
    {
        get { return height; }
        set { height = value; }
    }
    public double Width
    {
        get { return width; }
        set { width = value; }
    }
    public double Length
    {
        get { return length; }
        set { length = value; }
    }
    public static double VolumeCalculation(double length, double width, double height)
    {
        return length * width * height;
    }
    public static double LateralSurfaceAreaCalculation(double length, double width, double height)
    {
        return 2 * (length * height) + 2 * (width * height);
    }
    public static double SurfaceAreaCalculation(double length, double width, double height)
    {
        return 2 * (length * width) + 2 * (length * height) + 2 * (width * height);
    }
}