using System;
using System.Collections.Generic;
namespace figures;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }
    public override void SetColor(string feedb)
    {
        _color = feedb;
    }
    public override string GetColor()
    {
        return _color;
    }
    public override void Setfactor(double feedb, double a)
    {
        _length = feedb;
        _width = a;
    }
}