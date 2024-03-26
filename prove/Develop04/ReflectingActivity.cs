using System;

public class ReflectingActivity : Activity 
{
     //Class Attributes (private)
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();


    //Class Constructors
    public ReflectingActivity() : base()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        _prompts = new List<string>(){
            "Think back to a time when you faced a significant challenge or obstacle. How did you initially react to the situation?",
            "Describe the emotions you experienced during this challenging period. How did you cope with them?",
            "What specific actions did you take to confront the challenge you were facing?",
            "Reflect on the support systems or resources you relied on during this time. How did they contribute to your strength and resilience?",
            "Were there any particular moments or experiences that tested your resilience even further? How did you navigate through them?",
            "Think about the lessons you learned from overcoming this challenge. How have they shaped your perspective or behavior since then?",
            "Describe any personal qualities or characteristics that you believe helped you persevere through this difficult time.",
            "Did you encounter any setbacks or moments of doubt along the way? How did you overcome them?",
            "Reflect on the role of self-care and self-compassion during this challenging period. How did you prioritize your well-being?",
            "Looking back, how do you feel about the way you handled the situation? What aspects are you proud of?"
        };
        _questions = new List<string>(){
            "What were your immediate thoughts and feelings when you first encountered the challenge?",
            "How did you perceive the magnitude of the challenge at the outset?",
            "Did you experience any physical or emotional reactions in response to the situation?",
            "Describe the range of emotions you experienced throughout the challenging period.",
            "How did you manage and cope with these emotions that this challenge brought to you?",
            "Outline the steps you took to address the challenge.",
            "Were there any particular strategies or approaches that proved to be especially effective?",
            "Identify the individuals, communities, or resources that provided support during this time.",
            "How did their support impact your ability to navigate the challenge?",
            "Recall any specific instances or situations that posed additional challenges or setbacks."
        };
    }
    
    //Class Methods (responsabilities)
    public void Run() 
    {
        DisplayStartingMessage();

        DisplayPrompt();

        DisplayQuestions();        
        
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = new Random().Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        int index = new Random().Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"---{prompt}---");
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to begin");
        string input = Console.ReadLine();

        if (input == "")
        {
            Console.WriteLine("Now ponder on each of the following questions as they are related to this experience."); 
            Console.Write("You may begin in: ");
            ShowCountDown(5);
      
            Console.Clear();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid input. Please try again.");
            Console.ResetColor();
        }
    }

    public void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {   
            string question = GetRandomQuestion();
            Console.Write($"> {question}  ");
            ShowSpinner(10);
        }
        Console.WriteLine();
    }
}