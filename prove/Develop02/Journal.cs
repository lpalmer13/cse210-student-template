using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private PromptGenerator promptGenerator = new PromptGenerator();
    private FileHandler fileHandler = new FileHandler();

    public void WriteEntry()
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine("Choose prompt:");
        Console.WriteLine(prompt);

        Console.WriteLine("Enter your response:");
        string response = Console.ReadLine();

        Entry entry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), prompt, response);
        entries.Add(entry);

        Console.WriteLine("Entry saved. ");
    }
    
    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine();
        }
    }

    public void LoadEntries()
    {
        Console.WriteLine("Enter the filename to load:");
        string filename = Console.ReadLine();
        entries = fileHandler.Load(filename);
        Console.WriteLine("Entries loaded.");
    }

    public void SaveEntries()
    {
        Console.WriteLine("Enter the filename to save:");
        string filename = Console.ReadLine();
        fileHandler.Save(entries, filename);
        Console.WriteLine("Entries saved.");
    }
}