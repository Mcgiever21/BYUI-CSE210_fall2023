using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("input score: ");
        string value = Console.ReadLine();
        int score = int.Parse(value);
        string myletter = Program.grade(score);
        Console.WriteLine(myletter);
    }
 
    static string grade(int score)
    {
        int a = score;
        string letter;
        if (a>95)
        {
            letter = "A+";
        }
        else if (a==95){letter = "A";}
        else if (a>=90){letter = "A-";}
        else if (a>85){letter="B+";}
        else if (a==85){letter="B";}
        else if (a>=80){letter="B-";}
        else if (a>75){letter="C+";}
        else if (a==75){letter="C";}
        else if (a>=70){letter="C-";}
        else if (a>=60){letter="D";}
        else
        {letter = "F";}
       // Console.WriteLine(letter);
        return letter;
    }
}