using System;

namespace GoalTracker
{

    public abstract class Goal
    {
        protected  string _goalTerms;
        protected  string _gType;
        protected  bool _complete;
        protected  double _pointValue;
        protected  int _quantityCompleted;
        protected  int _quantityNeeded;

public virtual void SetType(string s)
    {
        _gType = s;
    }
    public virtual string GetType()
    {
        return _gType;
    }
    public virtual void SetComplete(bool b)
    {
        _complete = b;
    }
    public virtual bool GetComplete()
    {
        return _complete;
    }
    public virtual void SetPoints(double d)
    {
        _pointValue = d;
    }
    public virtual double GetPoints()
    {
        return _pointValue;
    }
    public virtual void SetCompletedNew(int i)
    {
        _quantityCompleted = 0;
    }
    public virtual void SetCompleted(int i)
    {
        _quantityCompleted = _quantityCompleted + i;
    }
    public virtual int GetCompleted()
    {
        return _quantityCompleted;
    }
    public virtual void SetTotalEventQ(int i)
    {
        _quantityNeeded = i;
    }
    public virtual int GetTotalEventQ()
    {
        return _quantityNeeded;
    }
    public virtual string GetGoal()
    {
        return _goalTerms;
    }
    public virtual void SetGoal(string s)
    {
        _goalTerms = s;
    }
}}