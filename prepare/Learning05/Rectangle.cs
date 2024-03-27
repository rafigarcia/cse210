using System;

class Rectangle : Shape
{
    //Attributes
    private double _length;
    private double _width;

    //Constructors
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public double GetLength ()
    {
        return _length;
    }

    public double GetWidth ()
    {
        return _width;
    }

    //methods
    public override double GetArea()
    {
        return _length * _width;
    }


}