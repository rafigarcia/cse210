using System;

public class PromptGenerator 
{
    public Random rnd = new Random();
    public string[] _prompts = 
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Describe a small victory or achievement you experienced. What did you learn from it?",
        "Share a challenge you faced today and how you dealt with it", 
        "Write about a place you visited today. What did you see, hear, or feel in that space?",
        "Reflect on a moment of kindness, whether given or received. How did it impact your day?",
        "Explore a new experience or something you learned today. What sparked your interest?",
        "Write about a goal or intention you set for the day. Did you achieve it, and how did it shape your day?",
        "Reflect on a moment of gratitude. What are you thankful for today?"
    };
    
    public string GetRandmPrompt()
    {
        int index = rnd.Next(_prompts.Length);
        return _prompts[index];
    }
}