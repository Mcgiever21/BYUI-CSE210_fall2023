using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography;
using System.Threading;
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
        Console.WriteLine(options1[RandomCounterOption(options1)]);
        int figure = 0;
        //g = TimeDelay(po);
        do{
        
            if(Console.ReadLine() == "finished"){figure = 2;}
            else{
                g++;
            }
        }while(figure == 0);

        return g;
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
     protected override int TimeDelay( int po)
    {
        Reflection reflection = new();
        int g = 0;
        animationNow.Add("|");
        animationNow.Add("/");
        animationNow.Add("-");
        animationNow.Add("\\");
        animationNow.Add("|");
        animationNow.Add("/");
        animationNow.Add("-");
        animationNow.Add("\\");
        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(po);
        int i = 0;
        int n = 0;
        do
        {
            
            Console.Write("\b \b");
            string s = animationNow[n];
            Console.WriteLine(i);
            //Console.Write(s);
            if (Console.KeyAvailable)
                { 
                    if (Console.ReadKey(true).Key == ConsoleKey.Enter){g++;}
                }
            Thread.Sleep(500);
            //Console.WriteLine("\b \b");
            i++;
            n++;
            if(n>=animationNow.Count){n=0;}
            if(actName == "Breathe"){
                if(i%12 == 0 ){Console.WriteLine(statement1);}
                if(i%6 == 0 && i%12 != 0){Console.WriteLine(statement2);}
            }
            if(actName == "Reflection")
            {
                if(i==1){Console.WriteLine(statement1);}
                
                if(i%20 == 0 /*&& i%6%2 == 0*/)
                    {
                    //Reflection reflect = new();
                    Console.WriteLine(reflection.RandomCounterOption2());
                    }
                
            }
            if(actName == "Listing")
            {
                if(i==1){Console.WriteLine(statement1);}
                
                
                if (Console.KeyAvailable)
                { 
                    if (Console.ReadKey(true).Key == ConsoleKey.Enter){
                        g++;
                        }
                }
            }
            Thread.Sleep(500);
        }while(DateTime.Now < EndTime);
        return g;
    }
}}