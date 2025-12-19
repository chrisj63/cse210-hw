using System;

public class Rectangle : Shape
{
    private double _length = 1;
    private double _width = 1;


    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _width * _length;
    }
}