using System;
using System.Collections.Generic;
using System.Security.Cryptography;
namespace relax{
class Listing : ActivityBase
{
    private int g;
    private List<string> options1;
    public void ActListing(string actin)
    {
        statement1 = "work on Finding the good things in life";
        actName = "Listing";
        ActStart(actin);
        ipo = ActRun();
        Console.WriteLine($"Hope you have a brighter look on life. \n you listed {1} items. \nYou were listing things for {0} seconds. \nReturning to main menu.", ipo, g);
    }
    public int ActRun()
    {
        options1 = new List<string>();
        Option1Filler();
        
        Console.WriteLine("Please specify how long to do the activity.");
        int po = int.Parse(Console.ReadLine());
        Console.WriteLine("Lets Begin \nPress ENTER each time you list something and I'll keep track of how many things you've listed.(keep track on your fingers as well)");
        statement1 = options1[RandomCounterOption(options1)];
        
        g = TimeDelay(po);
        return po;
    }
    public int RandomCounterOption(List<string> listy)
    {
        int ans2 = RandomNumberGenerator.GetInt32(listy.Count);
        return ans2;
    }
    
    private void Option1Filler()
    {
        options1.Add("List the times that you smiled or were smiled at this week");
        options1.Add("List the times that you saw a plant or animal in the last 2 days (ins't life amazing!)");
        options1.Add("List the times when someone said hello or you said hello to someone else in the last 3 days.");
        options1.Add("List the times you thought of something in the eternal perspective in the last 5 days.");
        options1.Add("List how many times you saw or spoke with a family member or friend in the last 6 days.");
        options1.Add("List the times in your life that stand out as a time when something affected you to the core");
        options1.Add("List the times when you felt God near you in the last 24 hours.");
    }
}}