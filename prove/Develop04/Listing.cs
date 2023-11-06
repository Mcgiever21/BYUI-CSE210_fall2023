using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography;
namespace relax{
class Listing : ActivityBase
{
    private int g;
    private List<string> options1= new List<string>
    {
        "List the times that you smiled or were smiled at this week",
        "List the times that you saw a plant or animal in the last 2 days (ins't life amazing!)",
        "List the times when someone said hello or you said hello to someone else in the last 3 days.",
        "List the times you thought of something in the eternal perspective in the last 5 days.",
        "List how many times you saw or spoke with a family member or friend in the last 6 days.",
        "List the times in your life that stand out as a time when something affected you to the core",
        "List the times when you felt God near you in the last 24 hours."
    };
    public int figure = 0;
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
        //options1 = new List<string>();
        //Option1Filler();
        
        Console.WriteLine("Please specify how long to do the activity.");
        int po = int.Parse(Console.ReadLine());
        Console.WriteLine("Lets Begin \nPress ENTER each time you list something and I'll keep track of how many things you've listed.(keep track on your fingers as well)");
        statement1 = options1[RandomCounterOption(options1)];
        figure = 0;
        //g = TimeDelay(po);
        do{
            Console.ReadLine();
            if(Console.ReadLine() == "finished"){figure = 2;}
            else{
                g++;
            }
        }while(figure = 0);

        return po;
    }
    public int RandomCounterOption(List<string> listy)
    {
        int ans2 = RandomNumberGenerator.GetInt32(listy.Count);
        return ans2;
    }
    
    /*private void Option1Filler()
    {
        "List the times that you smiled or were smiled at this week",
        "List the times that you saw a plant or animal in the last 2 days (ins't life amazing!)",
        "List the times when someone said hello or you said hello to someone else in the last 3 days.",
        "List the times you thought of something in the eternal perspective in the last 5 days.",
        "List how many times you saw or spoke with a family member or friend in the last 6 days.",
        "List the times in your life that stand out as a time when something affected you to the core",
        "List the times when you felt God near you in the last 24 hours."
    }*/
}}