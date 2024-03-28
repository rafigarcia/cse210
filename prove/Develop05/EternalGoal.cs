using System;

class EternalGoal : Goal
{
    //Constructor

    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal: {GetShortName()}~{GetDescription()}~{GetPoints()}";
    }

}
