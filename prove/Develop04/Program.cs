using System;
using System.Collections.Generic;
namespace relax{
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        Menu();
    }

    static public void Menu()
    {
        Breathe breathe = new();
        Reflection reflection = new();
        Listing listing = new();
        int sett = 0;
        while(sett == 0)
        {
            sett = 0;
            Console.WriteLine("Lets do some life expanding exercises.");
            Console.WriteLine("Select an option below to begin. \n1. Breathing exercises\n2. Reflection\n3. Listing");
            string menu_select = Console.ReadLine();
            if(menu_select == "5" || menu_select == "quit"){sett = 1; return;}
            ActivityBase activityBase = new();
        
            if (menu_select == "1"){
                
                string act = "Breathe";
                breathe.ActBreathe(act);
            }
            else if (menu_select == "2"){
                string act = "Reflection";
                reflection.ActReflection(act);
                
            }
            else if (menu_select == "3"){ 
                string act = "Listing";
                listing.ActListing(act);
            }
        }
    }
}}