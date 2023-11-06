using System;
using System.Collections.Generic;
namespace figures;

public abstract class Shape
{
    private string _color;

    public abstract string GetColor();
    public abstract void SetColor(string feedb);
    public abstract double GetArea();

}