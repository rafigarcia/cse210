using System;

public class ListingActivity : Activity
{
     //Class Attributes (private)
    private int _count = 0;
    private List<string> _prompts;


    //Class Constructors
    public ListingActivity() : base()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        _prompts = new List<string>()
        {
            "What was the most memorable moment of your day?",
            "How did you feel when you woke up this morning?",
            "What are you grateful for today?",
            "Did you encounter any challenges or obstacles? How did you overcome them?",
            "Who did you interact with today, and what was the nature of your interactions?",
            "What made you laugh today?",
            "What did you do to take care of yourself today?",
            "Describe a moment of kindness you witnessed or experienced.",
            "What goals did you work towards today?"
        };
    }


    //Class Methods (responsabilities)
    public void Run() 
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();

        Console.Write("You may begin in: ");
        ShowCountDown(5);

        List<string> responses = GetListFromUser();
        _count = responses.Count;

        if (_count == 0)
        {
            Console.WriteLine("You did not list anything. Please try again.");
        } 
        else if (_count == 1)
        {
            Console.WriteLine("You listed one item.");
        }
        else 
        {
            Console.WriteLine($"You listed {_count} items.");
        }

        Console.WriteLine();

        _count = 0;

        DisplayEndingMessage();
    }


    public void GetRandomPrompt() 
    {
        int index = new Random().Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[index]} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("> ");
            string input = Console.ReadLine();

            if (input  != "")
            {
                responses.Add(input);
            }
        }
        return responses;
    }


}