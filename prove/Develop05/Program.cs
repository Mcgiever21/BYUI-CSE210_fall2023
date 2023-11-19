using System;
using System.Collections.Generic;
using GoalTracker;


namespace GoalTracker
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Goal> _goalList = new();
            
            int _menu1input = 0;
            int quit = 3;
            int counter = 0;
            Repository repo = new();
            GRepeater gr = new();
            _goalList = repo.GoalReader();
            double _pointTotal = repo.TallyReader();

            do
            {
                printer(@"
Select from the menu provided:
1. view all recorded goals
2. record progress on a goal
3. view completed goals
4. view incomplete goals
5. create new goal
6. exit program
                "
                );
                _menu1input = int.Parse(Reader());
                switch (_menu1input)
                {
                    case 1:
                        foreach (Goal g in _goalList)
                        {
                            printer($"{g.GetGoal()}");
                        }
                        break;
                    case 2:
                        counter = 0;
                        foreach (Goal g in _goalList)
                        {
                            printer($"{counter} {g.GetGoal()}");
                            counter++;
                        }             
                        printer("enter number coresponding to goal");
                        int menu2 = int.Parse(Reader());    
                        if(_goalList[menu2-1].GetType() == "SimpleG")
                        {
                            _goalList[menu2-1].SetComplete(true);
                            _pointTotal = _pointTotal + _goalList[menu2-1].GetPoints();                           
                        }
                        else if (_goalList[menu2-1].GetType() == "EternalG")
                        {
                            _pointTotal = _pointTotal + _goalList[menu2-1].GetPoints();                            
                        }
                        else if (_goalList[menu2-1].GetType() == "CheckListG")
                        {
                            if(_goalList[menu2-1].GetCompleted() < _goalList[menu2-1].GetTotalEventQ())
                            {
                                _pointTotal = _pointTotal + _goalList[menu2-1].GetPoints();                              
                            }
                            else if (_goalList[menu2-1].GetCompleted() == _goalList[menu2-1].GetTotalEventQ())
                            {
                                _goalList[menu2-1].SetComplete(true);
                                _pointTotal = _pointTotal + _goalList[menu2-1].GetPoints() + 50;
                            }
                            else
                            {
                                _goalList[menu2-1].SetComplete(true);
                                _pointTotal = _pointTotal + _goalList[menu2-1].GetPoints();                               
                            }
                        }
                        break;
                    case 3:

                        int i = 0;
                        foreach (Goal g in _goalList)
                        {
                            i++;
                            if (g.GetComplete() == true)
                            {
                                printer($"{g.GetGoal}");
                                switch (g.GetType())
                                {
                                    case "SimpleG":

                                        SimpleG b = new();
                                        b = gr.Repeater(g);
                                        _goalList[i-1] = g;
                                    case "EternalG":

                                        EternalG e = new();
                                        e = gr.Repeater(g);
                                        _goalList[i-1] = g;
                                    case "ChecklistG":

                                        ChecklistG h = new();
                                        h = gr.Repeater(g);
                                        _goalList[i-1] = g;
                                }
                            }
                        }
                        break;
                    case 4:
                        foreach (Goal g in _goalList)
                        {
                            if (g.GetComplete() == false)
                            {
                                printer($"{g.GetGoal()}");
                            }
                        }
                        break;
                    case 5:

                        printer("Type how many times goal needs completed to terminate (eternal goals enter 0)");
                        int c = int.Parse(Reader());
                        if (c > 1)
                        {
                            SimpleG sim = new();
                            printer("Type Goal");
                            sim.SetGoal(Reader());
                            printer("Type point value for goal");
                            sim.SetPoints(double.Parse(Reader()));
                            sim.SetTotalEventQ(c);
                            sim.SetComplete(false);
                            sim.SetCompletedNew(0);
                            sim.SetType("SimpleG");
                            break;
                        }
                        else if ( c == 0 )
                        {
                            EternalG ete = new();
                            printer("Type Goal");
                            ete.SetGoal(Reader());
                            printer("Type point value for goal");
                            ete.SetPoints(Double.Parse(Reader()));
                            ete.SetTotalEventQ(1000000);
                            ete.SetComplete(false);
                            ete.SetCompletedNew(0);
                            ete.SetType("EternalG");
                            break;
                        }
                        else 
                        {
                            ChecklistG che = new();
                            printer("Type Goal");
                            che.SetGoal(Reader());
                            printer("Type point value for goal");
                            che.SetPoints(Double.Parse(Reader()));
                            che.SetTotalEventQ(c);
                            che.SetComplete(false);
                            che.SetCompletedNew(0);
                            che.SetType("EternalG");
                            break;
                        }
                    
                    case 6:
                        quit = 6;
                        break;
                }
            }while (quit != 6);
            repo.GoalWriter(_goalList);
            repo.TallyWriter(_pointTotal);
        }

        
    static void printer(string v)
    {
        Console.WriteLine(v);
    }
    static string Reader()
    {
        var v = Console.ReadLine();
        return v;
    }
    }

}