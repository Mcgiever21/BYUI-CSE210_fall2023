using System;
using System.Collections.Generic;
using System.Dynamic;

namespace GaussLaw
{
class Battery
{
    private double charge;
    public double ChargerGet()
    {
        return charge;
    }
    public void ChargerSet(double a)
    {
        charge = a;
    }

}
}

