using System;

public class Assigment 
{
    // Class Attributes (private)
    private string _studentName = "";
    private string _topic = "";

    //Class Constructors 
    public Assigment() {
        _studentName = "Anonimous";
        _topic = "None";
    }
    
    public Assigment(string studentName, string topic) {
        _studentName = studentName;
        _topic = topic;
    }
    
    
    //Class Getters & Setters
    public void SetStudenName(string studentName) 
    {
        _studentName = studentName;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }

    public string GetTopic()
    {
        return _topic;
    }

    // Class Methods (Responsabilities)

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}