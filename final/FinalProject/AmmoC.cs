using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace GaussLaw
{

public abstract class AmmoC
{
    protected double weight;
    protected double length;
    protected double ChargeCost;
    protected double FTS;

    public virtual double GetChargeCost()
    {
        return ChargeCost;
    }

    public virtual double FireStaging()
    {
        ChargeCost = weight * 0.0001;
        double mv = 1000*(21/timing())/12;
        double timing()
        {
            System.DateTime moment = new System.DateTime();
            double stage1 = moment.Millisecond;
            double stage2 = stage1 * FTS + stage1;
            double stage3 = (stage1 * FTS)/2 + stage2;
            double stage4 = (stage1 * FTS)/3 + stage3;
            double stage5 = (stage1 * FTS)/4 + stage4;
            double stage6 = (stage1 * FTS)/5 + stage5;
            double stage7 = (stage1 * FTS)/6 + stage6;
            double shotTime = stage7-stage1;
            return shotTime;
        }
        return mv;
    }



}
}
