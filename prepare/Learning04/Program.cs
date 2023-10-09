using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    public static string var1;
    private static string var2;
    static void Main(string[] args)
    {
        Assignment ass = new Assignment();
        MathAss mat = new MathAss();
        WritingAss writ = new WritingAss();
        ConsoleGetter con = new ConsoleGetter();
        

        
        Console.WriteLine("1 for math assignment, 2 or writing assignment");
        int num = int.Parse(Console.ReadLine());
        if (num ==1)
        {
            mat.setMathAssVar();
            ass._topic = "Math";
            var1 = mat._textbookSection;
            var2 = mat._problems;
        }
        else
        {
            writ.setwritAssVar();
            ass._topic = "Writing";
            var1 = writ._title;
            var2 = " ";
        }

        ass.GetSummary();
        con.DisplayAss(var1,var2);
        return;

    }
}