using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace relax{
class Reflection : ActivityBase
{
    private List<string> options1= new List<string>{
        "Think of a time when you were happy last week.",
        "Think of a time when you made someone else happy.",
        "Think of a time when someone did something nice for you.",
        "Think of a time when you tried your hardest to achieve a goal.",
        "Think of a time when your goals seemed just to far away.",
        "Think of a time when life got hard.",
        "Think of a time when life was easy."
    };
    private List<string> options2= new List<string>{
    "What was something that had to be overcome?",
        "How was your outlook at life changed after this experience?",
        "How did your experience effect those around you?",
        "What was learned from this experience?",
        "How would you say that your life has been changed by this experience?",
        "What will/have you do/done differently because of this experience?",
        "What will you do now for those around you because of this experience?"
    }
    ;
    
    public void ActReflection(string actin)
    {
        statement1 = "work on calming and expanding of sight through looking back at life's experiences";
        actName = "Reflection";
        ActStart(actin);
        ipo = ActRun();
        Console.WriteLine($"Hope you have a brighter look on life. You were reflecting for {0} seconds. Returning to main menu.", ipo);
    }
    public int ActRun()
    {
        //options1 = new List<string>();
        //options2 = new List<string>();
        //Option1Filler();
        //Option2Filler();
        Console.WriteLine("Please specify how long to do the activity.");
        int po = int.Parse(Console.ReadLine());
        Console.WriteLine("Lets Begin");
        statement1 = options1[RandomCounterOption(options1)];
        statement2 = options2[RandomCounterOption(options2)];
        int g = TimeDelay(po);
        return po;
    }
    static int RandomCounterOption(List<string> listy)
    {
        int ans2 = RandomNumberGenerator.GetInt32(listy.Count);
        return ans2;
    }
    public string RandomCounterOption2()
    {
        //Option2Filler();
        string ans3 = options2[RandomNumberGenerator.GetInt32(options2.Count)];
        return ans3;
    }
    /*private void Option1Filler()
    {
        options1.Add("Think of a time when you were happy last week.");
        options1.Add("Think of a time when you made someone else happy.");
        options1.Add("Think of a time when someone did something nice for you.");
        options1.Add("Think of a time when you tried your hardest to achieve a goal.");
        options1.Add("Think of a time when your goals seemed just to far away.");
        options1.Add("Think of a time when life got hard.");
        options1.Add("Think of a time when life was easy.");
    }
    private void Option2Filler()
    {
        "What was something that had to be overcome?",
        "How was your outlook at life changed after this experience?",
        "How did your experience effect those around you?",
        "What was learned from this experience?",
        "How would you say that your life has been changed by this experience?",
        "What will/have you do/done differently because of this experience?",
        "What will you do now for those around you because of this experience?"
    }*/
    
}}