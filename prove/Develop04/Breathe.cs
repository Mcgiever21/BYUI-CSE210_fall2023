using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace relax{

public class Breathe : ActivityBase
{
    
    string bIn = "Breathe In";
    string bOut = "Breathe Out";

    public void ActBreathe(string actin)
    {
        statement1 = "work on calming through breathing";
        actName = "Breathe";
        ActStart(actin);
        ipo = ActRun();
        Console.WriteLine($"Hope you feel better now. You were breathing for {0} seconds. Returning to main menu.", ipo);
    }
    public int ActRun()
    {
        Console.WriteLine("Please specify how long to do the activity.");
        int po = int.Parse(Console.ReadLine());
        Console.WriteLine("Lets Begin");
        statement1 = bIn;
        statement2 = bOut;
        int g = TimeDelay(po);
        return po;
    }
    

}}