using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace figures;

public abstract class Shape
{
    protected string _color;

    public abstract string GetColor();
    public abstract void SetColor(string feedb);

    public abstract double GetArea();
    public abstract void Setfactor(double feedb, double a);

}