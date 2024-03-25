using System;

public class WritingAssigment : Assigment
{
    // Class Attributes (private)
    private string _title = "";

    //Class Constructors
    public WritingAssigment() : base()
    {
        _title = "Undefined";
    }

    public WritingAssigment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    //Class Methods (responsabilities)
    public string GetWritingInformation()
    {
        return $"{GetStudentName()} by {_title}";
    }

}