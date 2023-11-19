using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace GoalTracker
{

public class Repository
{
    string goalkeeper = "goalkeeper";
    string pointkeeper = "pointkeeper.txt";

    public void GoalWriter(List<Goal> G)
    {
        
        //format: _gtype | _pointValue | _Complete | _quantityCompeted | _quantityNeeded
        if (File.Exists(goalkeeper))
        { 
            File.WriteAllText(goalkeeper, string.Empty);
            foreach (var i in G)
            {
                File.AppendAllText(goalkeeper, $"{i.GetType()}|{i.GetPoints()}|{i.GetComplete()}|{i.GetCompleted()}|{i.GetTotalEventQ()}");
            }
        }
        else
        {
            File.Create(goalkeeper);
            foreach (var i in G)
            {
                File.AppendAllText(goalkeeper, $"{i.GetType()}|{i.GetPoints()}|{i.GetComplete()}|{i.GetCompleted()}|{i.GetTotalEventQ()}");
            }
        }
    }
    public List<Goal> GoalReader()
    {
        //format: _gtype | _pointValue | _Complete | _quantityCompleted | QuantityNeeded
        List<Goal> Goals = new();
        if(File.Exists(goalkeeper) == true)
        {
            string[] _fileR = File.ReadAllLines(goalkeeper);
            string part1 = "";
                foreach (string line in _fileR)
                {
                    if (line == "" || line ==" "){}
                    else{
                        string[] parts = line.Split("|");
                        part1 = parts[0];
                        switch (part1)
                        {
                            case "SimpleG":
                                SimpleG sim = new();
                                sim.SetType(parts[0]);
                                sim.SetPoints(Convert.ToDouble(parts[1]));
                                sim.SetComplete(Convert.ToBoolean(parts[2]));
                                sim.SetCompleted(int.Parse(parts[3]));
                                sim.SetTotalEventQ(int.Parse(parts[4]));
                                Goals.Add(sim);
                                break;
                            case "EternalG":
                                EternalG eter = new();
                                eter.SetType(parts[0]);
                                eter.SetPoints(Convert.ToDouble(parts[1]));
                                eter.SetComplete(Convert.ToBoolean(parts[2]));
                                eter.SetCompleted(int.Parse(parts[3]));
                                eter.SetTotalEventQ(int.Parse(parts[4]));
                                Goals.Add(eter);
                                break;
                            case "CheckListG":
                                ChecklistG chek = new();
                                chek.SetType(parts[0]);
                                chek.SetPoints(Convert.ToDouble(parts[1]));
                                chek.SetComplete(Convert.ToBoolean(parts[2]));
                                chek.SetCompleted(int.Parse(parts[3]));
                                chek.SetTotalEventQ(int.Parse(parts[4]));
                                Goals.Add(chek);
                                break;
                        }
                    }
                }
            return Goals;
        }
        else{File.Create(goalkeeper);return Goals;}
    }
    
    public void TallyWriter(double pt)
    {
        if (File.Exists(pointkeeper))
        { 
            File.WriteAllText(pointkeeper, Convert.ToString(pt));
        }
        else{File.Create(pointkeeper, Convert.ToInt32(pt));}
    }
    public double TallyReader()
    {
        double pt = 0;
        if (File.Exists(pointkeeper))
        { 
            pt = int.Parse(File.ReadAllText(pointkeeper));
            return pt;
        }
        else{return pt;}
    }

}
}