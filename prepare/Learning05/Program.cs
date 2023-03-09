using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 5);
        Rectangle rectangle = new Rectangle("blue", 4, 6);
        Circle circle = new Circle("green", 3);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();


            Console.WriteLine($"The {shape.GetType()} has a color of {color} and an area of {area}.");
        }
    }
}