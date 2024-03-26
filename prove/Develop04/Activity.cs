using System;

public class Activity 
{
    // Class Attributer (private)
    private string _name = "";
    private string _description = "";
    private int _duration = 0;

    // Class Constructors 
    public Activity ()
    {
        SetName("Activity");
        SetDescription("This is a generic activity");
        _duration = 0;
    }

    //Class Setters & Getters 
    public void SetName(string name)
    {
         _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    //Class Methods (responsabilities)
    public void DisplayStartingMessage() 
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine();

        Console.WriteLine(_description);
        Console.WriteLine();

        Console.WriteLine("How long, in seconds, would you like for you session to last?");
        _duration = int.Parse(Console.ReadLine());

        ShowCountDown(5);
        Console.Clear();

        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

    }

    public void DisplayEndingMessage() 
    {
        Console.WriteLine($"Well done!! You completed the {_name} activity");
        ShowSpinner(5);

        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of {_name} activity");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("\b\\");
            Thread.Sleep(500);

            Console.Write("\b|");
            Thread.Sleep(500);

            Console.Write("\b/");
            Thread.Sleep(500);

            Console.Write("\b-");
            Thread.Sleep(500);
        }
        Console.WriteLine("\b ");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            for (int j = 0; j < i.ToString().Length; j++)
            {
                Console.Write("\b \b");
            }
        }
        Console.WriteLine(" ");
    }

}