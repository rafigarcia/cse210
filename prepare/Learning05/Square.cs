using System;

class Square : Shape
{
    //Attributes
    private double _side;

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    //Setter & Getter 
    public double GetSide()
    {
        return _side;
    } 

    public override double GetArea()
    {
        return _side * _side;
    }
}