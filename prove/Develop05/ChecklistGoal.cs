using System;

class ChecklistGoal : Goal 
{
    //Attributes
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    //Constructors
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    //Setters & Getters

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }

    public override int RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            return GetPoints() + _bonus;
        } else if (_amountCompleted > _target)
        {
            Console.WriteLine("You have already competed this goal. Save a new goal!");
            return 0;
        } else 
        {
            return GetPoints();
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetailsString()
    {
        string detailsString = base.GetDetailsString();
        return $"{detailsString} -- Currently Completed: {GetAmountCompleted()}/{GetTarget()}";
    }
    
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {GetShortName()}~{GetDescription()}~{GetPoints()}~{GetAmountCompleted()}~{GetTarget()}";
    }
}