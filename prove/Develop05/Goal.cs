namespace GoalSetter
{
    public class Goal
    {
        private string _name = "";
        private string _desc = "";
        private int _points = 0;

        protected bool _complete = false;

        public Goal(string name, string desc, int points)
        {
            _name = name;
            _desc = desc;
            _points = points;
            _earnedPoints = earnedPoints;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDesc()
        {
            return _desc;
        }

        public virtual int GetEarnedPoints()
        {
            return _earnedPoints;
        }

        public virtual void RecordProgress()
        {
            // different for each goal
        }

        public virtual bool IsComplete()
        {
            return _complete;
        }

        public override string ToString()
        {
            // TODO: this is cruddy, make a better goal string
            return $"The goal is complete: {_complete}";
        }

        public virtual void AddPoints (int points)
        {
            _earnedPoints += points;
        }

        public virtual void MarkCompleted()
        {

            
        }
    }
}