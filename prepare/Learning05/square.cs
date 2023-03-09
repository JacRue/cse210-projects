public class Square : Shape
{
    private double side;

    public Square(string color, double side) : base(color)
    {
        this.side = side;
    }
    public override double GetArea()
    {
        return side * side;
    }

    public void SetColor(string color)
    {
        base.color = color;
    }
}