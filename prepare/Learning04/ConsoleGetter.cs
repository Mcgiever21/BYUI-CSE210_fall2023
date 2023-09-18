using System;
using System.Collections.Generic;

class ConsoleGetter
{
    public string  Getter(string variable)
    {
        Console.WriteLine($"/nInput {variable}:");
        return Console.ReadLine();
    }
}