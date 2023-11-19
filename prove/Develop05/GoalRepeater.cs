using System;

namespace GoalTracker
{

public class GRepeater
{
    public Goal Repeater(Goal g)
    {
        Console.WriteLine("Would you like to repeat goal?");
        string ans = Console.ReadLine();
        if (ans =="yes" || ans == "Yes")
        {
            string gt = g.GetGoal();
            string t = g.GetType();
            bool c = false;
            double pv = g.GetPoints();
            int qc = 0;
            int qn = g.GetTotalEventQ();
            switch (t) {
                case t=="SimpleG":
                    SimpleG sg = new();
                    sg.SetType(t);
                    sg.SetComplete(c);
                    sg.SetPoints(pv);
                    sg.SetCompletedNew(qc);
                    sg.SetTotalEventQ(qn);
                    sg.SetGoal(gt);
                    return sg;
                case t =="EternalG":
                    EternalG eg = new();
                    eg.SetType(t);
                    eg.SetComplete(c);
                    eg.SetPoints(pv);
                    eg.SetCompletedNew(qc);
                    eg.SetTotalEventQ(qn);
                    eg.SetGoal(gt);
                    return eg;
                case t=="ChecklistG":
                    ChecklistG cg = new();
                    cg.SetType(t);
                    cg.SetComplete(c);
                    cg.SetPoints(pv);
                    cg.SetCompletedNew(qc);
                    cg.SetTotalEventQ(qn);
                    cg.SetGoal(gt);
                    return cg;
            }
        }
        else{return g;}
    }
}

}