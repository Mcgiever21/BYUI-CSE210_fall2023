namespace GoalSetter
{
public class Repository
{
    public virtual void Add(Goal goal)
    {
        throw new Exception("not implemented in base class");

    }

    public virtual List<Goal> GetAll()
    {
        throw new Exception("not implemented in base class");

    }

    public virtual void Remove(Goal goal)
    {
        throw new Exception("not implemented in base class");

    }
}

}