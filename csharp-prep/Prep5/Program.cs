using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        Program.displayWelcome();
        string name = Program.promtUserName();
        int usnum = Program.promtUserNumber();
        int sqnum = Program.squareNumber();
        Program.displayResults(name, usnum, sqnum);
        return;
    }
    static void displayWelcome()
    {
        Console.WriteLine("welcome");
        return;
    }
    static string promtUserName()
    {
        Console.WriteLine("input user name: ");
        string name = Console.ReadLine();
        return name;
    } 
    static int promtUserNumber()
    {
        Console.WriteLine("input user number: ");
        int usnum = int.Parse(Console.ReadLine());
        return usnum;
    }
    static int squareNumber()
    {
        Console.WriteLine("Input number to be squared: ");
        int sqnum = int.Parse(Console.ReadLine());
        sqnum=sqnum*sqnum;
        return sqnum;
    }
    static void displayResults(string name, int usnum, int sqnum)
    {
        Console.WriteLine($"Username : {name} \nUser number: {usnum} \nnumber squared: {sqnum}");
        return;
    }
}