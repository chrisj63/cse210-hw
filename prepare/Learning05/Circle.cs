using System;

public class Circle : Shape
{
    private double _radius = 1;
    private double _areaCircle;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
        _areaCircle = radius * radius * Math.PI;
    }

    public override double GetArea()
    {
        return _areaCircle;
    }
}
