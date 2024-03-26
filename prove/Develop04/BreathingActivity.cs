using System;

public class BreathingActivity : Activity
{
    //Class Attributes (private)
    // For this child class we won't need any attributes.


    //Class Constructors
    public BreathingActivity() : base()
    {
        SetName("Breathing Activity");
        SetDescription("This activity is designed to help you get into a good state of breathing.");
    }

    //Class Methods (responsabilities)

    public void Run() 
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in....");
            ShowCountDown(5);

            Console.WriteLine("Now Breathe out....");
            ShowCountDown(5);

            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}