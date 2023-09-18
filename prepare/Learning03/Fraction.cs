using System;
using System.Collections.Generic;

namespace learning03;


class Fraction
{
    private int _top;
    private int _bottom;

public string GetFractionString()
{
    string fracstring = $"{_top}/{_bottom}";
    return fracstring;
}

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public Decimal GetFractionDecimal()
    {
        Decimal fractionDecimal = Decimal.Divide(_top,_bottom);
        return fractionDecimal;
    }

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int Top)
    {
        _top = Top;
        _bottom = 1;
    }

    public Fraction(int Top, int Bottom)
    {
        _top = Top;
        _bottom = Bottom;
    }

}