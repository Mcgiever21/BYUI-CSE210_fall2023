using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        int looperVariable = 1;

        while (looperVariable>0)
        {
            List<float> baseNumberList = Program.numberEnter();
            Console.WriteLine("Do you want the list sorted?");
            string answer = Console.ReadLine();

            if(answer == "yes"){
                List<float> numberListSorted = new List<float>(Program.sorter(baseNumberList));
                
                foreach (float number in numberListSorted)
                {
                    Console.WriteLine(number);
                }
            }
            Program.math(baseNumberList);
            Console.WriteLine("Would you like to run another list?");

            answer = Console.ReadLine();

            if (answer == "no" ) { looperVariable = 0 ; }
        }
    }

    static List<float> numberEnter()
    {
        List<float> baseNumberList = new List<float>();
        Console.WriteLine("Enter numbers one at a time at promt, enter 0 when finished.");

        float valueInput;
        do
        {
            Console.WriteLine("Enter a number: ");
            valueInput = float.Parse(Console.ReadLine());
            baseNumberList.Add(valueInput);

        } while (valueInput != 0);

        Console.WriteLine($"total number of items in list: {baseNumberList.Count}");
        
        foreach (float number in baseNumberList)
        {
            Console.WriteLine(number);
        }

        return baseNumberList;
    }
    
    static List<float> sorter(List<float> baseNumberList)
    {
        List<float> listsorted = new List<float>();
        int len = baseNumberList.Count();
        int i = 0;

        do
        {
            listsorted.Add(baseNumberList[i]);
            i += 1;
            len -= 1;
            
        }while(len>0);

        listsorted.Sort();

        return listsorted;
    }
    static void math(List<float> baseNumberList)
    {
        float sum = 0;
        int counter = 0;
        float largest = -10000;
        float smallest = 10000;

        for (int i = 0 ; i<baseNumberList.Count ; i++){
            sum += baseNumberList[i];
            counter += 1;

            if (baseNumberList[i]>largest){
                largest = baseNumberList[i];
            }

            if (baseNumberList[i]<smallest){
                smallest = baseNumberList[i];
            }
        }

        Console.WriteLine($"sum of list = {sum}");

        float avg = sum/counter;

        Console.WriteLine($"List Average = {avg}");
        Console.WriteLine($"the largest number is {largest}");
        Console.WriteLine($"the smallest number is {smallest}");
    }
    
}