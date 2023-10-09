using System;
using System.Collections.Generic;


public class Assignment
{
    private string _studentName = "Student Name";
    public string _topic = "Topic";


    private void SetAssVariables()
    {
        //ConsoleGetter con = new ConsoleGetter();
        string var = "studentname";
        _studentName = SetVar(var);
        //var = _topic;
        //_topic = SetVar(var);
    }

    public string SetVar(string var)
    {
        ConsoleGetter con = new ConsoleGetter();
        return con.Getter(var);
    }
    public void GetSummary()
    {
        SetAssVariables();
        Console.WriteLine($"{_studentName} - {_topic}");
    }
}