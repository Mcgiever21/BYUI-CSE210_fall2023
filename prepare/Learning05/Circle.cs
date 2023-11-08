using System;
using System.Collections.Generic;
namespace figures;

public class Circle : Shape
{
    private double _radius;
    public override double GetArea()
    {
        double area = 2*_radius*3.14;
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
        _radius = feedb;
    }
    
}