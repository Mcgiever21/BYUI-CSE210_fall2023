using System;
using System.ComponentModel.DataAnnotations;

public class Catch22{
    public int ErrorControl = 2;
    public int numControlYear = 2;

    public int numC = 5;

public string ExceptionInput( string i)
{
    if (i == "yes"){ErrorControl = 1; return ""; }
    else if (i == "no"){ ErrorControl = 1; return ""; }
    else {ErrorControl = 2; throw new ArgumentException( string.Format("answer was out of bounds, please type 'yes' or 'no'.")); }
}
          
public string ExceptionYear(string Y)
{
    if (!int.TryParse( Y , out int result))
    {
        Console.WriteLine($"{0} is not an integer", Y);
        numControlYear = 2;
        throw new FormatException( string.Format("answer is out of bounds or is not a number."));
        
    }
    else { numControlYear = 1; return ""; }
    
}

public string YearAdapt(string B,string D )
{
    int C = int.Parse(B);
    int E = int.Parse(D);
    if (E>C)
    {
        numControlYear = 2;
        throw new ArgumentException( string.Format("Start year is greater than final year, please input valid start year."));
    }
    else{ numControlYear = 1; return "";}
}

public string numCheck(string a)
{
    if (!int.TryParse(a, out int result))
    {
        Console.WriteLine($"{0} is not an integer", a);
        numC = 2;
        throw new FormatException( string.Format("answer is out of bounds or is not a number."));
    }
    else{numC = 0; return "";}
}
}