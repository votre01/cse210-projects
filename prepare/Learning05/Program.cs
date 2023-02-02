using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 13);
        Rectangle rectangle = new Rectangle("Green", 12, 7.3);
        Circle circle = new Circle("Blue", 9.2);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} Area: {shape.GetArea()}");
        }
    }
}