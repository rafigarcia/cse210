using System;

class Shape 
{
    //Attributes
    private string _color;


    //Constructors
    public Shape(string color)
    {
        _color = color;
    }
    
    //Setters & Getters
    public void SetColor(string color)
    {
       _color = color;
    }

    public string GetColor ()
    {
        return _color;
    }
    
    //Methods
    public virtual double GetArea() 
    {
        return 15.44;
    }

}