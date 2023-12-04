using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;


namespace GaussLaw
{

class Repository
{
    private string path = "shotimer.txt";
    private string path2 = "keeper1.txt";
    public void Saver(double battCharge, int shotCount)
    {
        //File.Create(path2);
        File.WriteAllText(path2, $"{battCharge}|{shotCount}");
    }
    public (double battCharge, int shotCount) Caller()
    {
        double battCharge = 0;
        int shotCount = 0;
        if(File.Exists(path2) == true)
        {
            string[] _fileR = File.ReadAllLines(path2);
                foreach (string part in _fileR)
                {
                    string[] parts = part.Split("|");
                    battCharge = double.Parse(parts[0]);
                    shotCount = int.Parse(parts[1]);
                }
        }
        return (battCharge, shotCount);
    }
    public void FSW(double shot)
    {
        if (!File.Exists(path))
        {
            File.Create(path);
        }
        using(System.IO.StreamWriter sw = File.AppendText (path)){sw.WriteLine(shot);}
        
    }
    public void FSR()
    {
        if (!File.Exists(path))
        {
            Console.Write(File.ReadLines(path));
        }
        else{Console.WriteLine("no shots recorded");}
        
    }
}
}

