using System;
using System.Data;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public PromptGenerator promptGenerator = new PromptGenerator();

    public string Write()
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = promptGenerator.GetRandmPrompt();
        Console.WriteLine(_promptText);
        return _entryText = Console.ReadLine();
    }

    
    public void Display()
    {
        Console.WriteLine($"{_date} - Prompt: {_promptText}\n\nEntry: {_entryText}");
    }

}