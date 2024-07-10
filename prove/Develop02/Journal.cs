using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private PromptGenerator promptGenerator = new PromptGenerator();

    public void WriteEntry()
    {
        string prompt = promptGenerator.SelectPrompt();
        Console.WriteLine($"{prompt}");
        Console.Write("> ");
        string response = Console.ReadLine();
        Entry entry = new Entry(prompt, response,DateTime.Now.ToString());
        entries.Add(entry);
        Console.WriteLine("Entry saved. ");
    }
    
    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine($"\nDate: {entry.Date} - Prompt: {entry.Prompt}");
            Console.WriteLine($"{entry.Response}");
        }
    }

     public void SaveJournal(string filename)
    {
        FileHandler.SaveToFile(entries, filename);
        Console.WriteLine("Journal saved.");
    }

    public void LoadJournal(string filename)
    {
        entries = FileHandler.LoadFromFile(filename);
        Console.WriteLine("Journal loaded.");
    }
}