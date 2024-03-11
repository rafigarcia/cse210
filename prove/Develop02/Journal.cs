using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries;
    
    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry()
    {
        Entry entry = new Entry();
        entry.Write();
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
        
    }
    public void SaveToFile()
    {
        Console.WriteLine("What would you like to name your file?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }

        }
        Console.WriteLine("Your file has been saved.");
        _entries.Clear();
    }
    public void LoadFromFile()
    {
        Console.WriteLine("What file would you like to load?");
        string filename = Console.ReadLine();
        
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            _entries.Add(entry);
        }
    }
}