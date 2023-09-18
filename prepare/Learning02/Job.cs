using System;
using System.ComponentModel.DataAnnotations;

public class Job
{   

    public string _jobTitle = "";
    public string _company = "";
    public string _startYear;
    public string _endYear;
    
    public void Display(Job i)
    {
        Console.WriteLine($"title: {i._jobTitle}\nCompany: {i._company}\nstarting year: {i._startYear}\nEnd Year: {i._endYear}");
    }

}