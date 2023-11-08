using System;
using System.Collections.Generic;
namespace figures;

public class Square : Shape
{
    private double _side;

    public override double GetArea()
    {
        double area = _side*_side;
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
        _side = feedb;
    }
}