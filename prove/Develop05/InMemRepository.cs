namespace GoalSetter
{
public class InMemRepository
{
    private List<Goal> _goal = new List<Goal>();
    public void Add(Goal goal)
    {
        if (!_goal.Contains(goal))
        {
        _goal.Add(goal);
        }

    }

    public List<Goal> GetAll()
    {
        throw new Exception("not implemented in base class");

    }

    public void Remove(Goal goal)
    {
        if (_goal.Contains(goal))
        {
        _goal.Remove(goal);
        }

    }
}

}