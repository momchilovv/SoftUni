public class Rectangle
{
    private Point topLeft;
    private Point bottomRight;

    public Rectangle(Point topLeft, Point bottomRight)
    {
        this.bottomRight = bottomRight;
        this.topLeft = topLeft;
    }
    public bool Contains(Point point)
    {
        return topLeft.X <= point.X && bottomRight.X >= point.X
            && topLeft.Y <= point.Y && bottomRight.Y >= point.Y;
    }
}