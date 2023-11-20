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
7. view total points earned
                "
                );
                _menu1input = int.Parse(Reader());
                switch (_menu1input)
                {
                    case 1:
                        foreach (Goal g in _goalList)
                        {
                            g.GetGoal();
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        counter = 0;
                        if(_goalList.Count == 0){Console.WriteLine("no goals recorded."); break;}
                        else{
                            foreach (Goal g in _goalList)
                            {
                                printer($"{counter}");
                                g.GetGoal();
                                counter++;
                            }             
                            printer("\n\nenter number coresponding to goal");
                            int menu2 = int.Parse(Reader());    
                            if(_goalList[menu2] is SimpleG)
                            {
                                _goalList[menu2].SetComplete(true);
                                _goalList[menu2].SetCompleted(1);
                                _pointTotal = _pointTotal + _goalList[menu2].GetPoints();    
                                //g.Repeater();                       
                            }
                            else if (_goalList[menu2] is EternalG)
                            {
                                _pointTotal = _pointTotal + _goalList[menu2].GetPoints();                            
                            }
                            else if (_goalList[menu2] is ChecklistG)
                            {
                                if(_goalList[menu2].GetCompleted() < _goalList[menu2].GetTotalEventQ())
                                {
                                    _pointTotal = _pointTotal + _goalList[menu2].GetPoints();    
                                    _goalList[menu2].SetCompleted(1);                          
                                }
                                else if (_goalList[menu2].GetCompleted() == _goalList[menu2].GetTotalEventQ())
                                {
                                    _goalList[menu2].SetComplete(true);
                                    _goalList[menu2].SetCompleted(1);
                                    _pointTotal = _pointTotal + _goalList[menu2].GetPoints() + 50;
                                }
                                else
                                {
                                    _goalList[menu2].SetComplete(true);
                                    _goalList[menu2].SetCompleted(1);
                                    _pointTotal = _pointTotal + _goalList[menu2].GetPoints();                               
                                }
                            }
                            break;
                        }
                    case 3:

                        int i = 0;
                        foreach (Goal g in _goalList)
                        {
                            i++;
                            if (g.GetComplete() == true)
                            {
                                g.GetGoal();
                                
                                /*switch (g.GetType())
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
                                }*/
                            }
                        }
                        break;
                    case 4:
                        foreach (Goal g in _goalList)
                        {
                            if (g.GetComplete() == false)
                            {
                                g.GetGoal();
                            }
                        }
                        break;
                    case 5:

                        printer("Type how many times goal needs completed to terminate (eternal goals enter 0)");
                        int c = int.Parse(Reader());
                        if (c == 1)
                        {
                            SimpleG sim = new();
                            printer("Type Goal");
                            sim.SetGoal(Reader());
                            printer("\nType point value for goal");
                            sim.SetPoints(double.Parse(Reader()));
                            sim.SetTotalEventQ(c);
                            sim.SetComplete(false);
                            sim.SetCompletedNew(0);
                            sim.SetType("SimpleG");
                            _goalList.Add(sim);
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
                            _goalList.Add(ete);
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
                            che.SetType("ChecklistG");
                            _goalList.Add(che);
                            break;
                        }
                    
                    case 6:
                        quit = 6;
                        break;
                    case 7:
                        printer(_pointTotal.ToString());
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