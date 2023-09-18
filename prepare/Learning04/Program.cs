using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment ass = new Assignment();
        MathAss mat = new MathAss();
        WritingAss writ = new WritingAss();

        ass.GetSummary();
        Console.WriteLine("1 for math assignment, 2 or writing assignment");
        int num = int.Parse(Console.ReadLine());
        if (num <=1)
        {
            mat.GetHomeworkList();
        }
        else
        {
            writ.GetBookList();
        }
        return;

    }
}