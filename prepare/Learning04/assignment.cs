using System;
using System.Collections.Generic;


public class Assignment
{
    private string _studentName;
    private string _topic;


    private void SetAssVariables()
    {
        ConsoleGetter con = new ConsoleGetter();
        string var = "studentname";
        _studentName = con.Getter(var);
        var = _topic;
        _topic = con.Getter(var);
    }

    public string SetVar(string var)
    {
        ConsoleGetter con = new ConsoleGetter();
        return con.Getter(var);
    }
    public string GetSummary()
    {
        SetAssVariables();
        return ($"{_studentName} - {_topic}");
    }
}