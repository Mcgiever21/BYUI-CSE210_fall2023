namespace GoalSetter
{
    
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Repository repo = new InMemRepository();
            Goal simpleGoal = new SimpleGoal("Exercise.","I want to exercise once, tomorrow", 1000);
            Console.WriteLine(simpleGoal.ToString());
            repo.Add(simpleGoal);
            int numberOfGoals = repo.GetAll().Count;

            Console.WriteLine($"there are {numberOfGoals} in the system");

            simpleGoal.MarkCompleted();
            simpleGoal.AddPoints(simpleGoal.GetPoints());
             Console.WriteLine()
        }
    }
}