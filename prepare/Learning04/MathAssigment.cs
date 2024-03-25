using System;

public class MathAssigment : Assigment
{
    //Class private Attributes
    private string _textbookSection = "";
    private string _problems = "";

    //Class Constructors
    public MathAssigment() : base()
    {
        _textbookSection = "Undefinded";
        _problems = "Emphtyed";
    }

    public MathAssigment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    //Class Methods (responsibilities)
    public string GetHomeworkList() 
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
    
}

