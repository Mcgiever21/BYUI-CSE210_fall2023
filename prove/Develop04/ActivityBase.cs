using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Input;



namespace relax{
public class ActivityBase
{
    protected string statement1 ;
    protected string statement2;
    protected string actName;
    protected int ipo;
    protected List<string> animationNow = new List<string>();
    
    public void ActStart(string act)
    {
        actName = act;
        if(actName == "Breathe"){
            Breathe breathe = new();
            Console.WriteLine($"Welcome, the activity selected is \n{actName} \nwhich will \n{statement1}. \n ");
            Console.WriteLine("Would you like to continue?");
            string ans = Console.ReadLine();
            if (ans == "yes")
            {
                /*ipo = breathe.ActRun();
                Console.WriteLine($"Hope you feel better now. You were breathing for {0} Returning to main menu.", ipo);*/
                return;
            }
        else{Program.Menu();}}
        if(actName == "Reflection"){
            Reflection reflect = new();
            Console.WriteLine($"Welcome, the activity selected is \n{actName} \nwhich will \n{statement1}. \n ");
            Console.WriteLine("Would you like to continue?");
            string ans = Console.ReadLine();
            if (ans == "yes")
            {
                return;
            }
        else{Program.Menu();}}
        if(actName == "Listing"){
            Listing listing = new();
            Console.WriteLine($"Welcome, the activity selected is \n{actName} \nwhich will \n{statement1}. \n ");
            Console.WriteLine("Would you like to continue?");
            string ans = Console.ReadLine();
            if (ans == "yes")
            {
                return;
            }
        else{Program.Menu();}}
    }

     //  private List<string> animationNow = new List<string>();
     //  animationNow.Add("|");
     //  animationNow.Add("/");
     //  animationNow.Add("-");
     //  animationNow.Add("\\");
     //  animationNow.Add("|");
     //  animationNow.Add("/");
     //  animationNow.Add("-");
     //  animationNow.Add("\\");

    protected int TimeDelay( int po)
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
            //if (Console.KeyAvailable)
                //{ 
                  //  if (Console.ReadKey(true).Key == ConsoleKey.Enter){g++;}
              //  }
            Thread.Sleep(1000);
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
        }while(DateTime.Now < EndTime);
        return g;
    }
}}

