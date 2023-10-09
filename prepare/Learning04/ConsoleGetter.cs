using System;
using System.Collections.Generic;

class ConsoleGetter
{
    public string  Getter(string variable)
    {
        Console.WriteLine($"Input {variable}:");
        return Console.ReadLine();
    }

    public void DisplayAss(string var1, string var2)
    {
        Console.WriteLine($"{var1}, {var2}");
    }
}