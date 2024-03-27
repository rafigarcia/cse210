using System;

public class Goal 
{
    //Attributes
    private string _shortName;
    private string _description;
    private string _points;


    //Constructors
    public Goal(string shortName, string description, string points)
    {

    }

    //Setters & Getters

    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }

    public void SetDescription (string description)
    {
        _description = description;
    }

    public void SetPoints(string points)
    {
        _points = points;
    }

}