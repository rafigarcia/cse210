using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Get Areas of different shapes");

        List<Shape> _shapes = new List<Shape>();

        Square square1 = new Square("Blue", 16.5);
        _shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Red", 15, 8.9);
        _shapes.Add(rectangle1); 

        Circle circle1 = new Circle("Green", 12.25);
        _shapes.Add(circle1);

        foreach (Shape shape in _shapes)
        {
            double area = shape.GetArea();
            Console.WriteLine("Area of {0} is {1}", shape.GetColor(), area);
        }


    }
}