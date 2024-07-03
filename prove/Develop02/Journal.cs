using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries;
    
    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string prompt)
    {
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        Entry entry = new Entry(prompt, response);
        entries.Add(entry);
        Console.WriteLine("Entry added successfully.");
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.ToFileString());
            }       
        }
        Console.WriteLine("Journal saved successfully.");
    }    
    public void LoadFromFile()
    {
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                if (parts.Length ==3)
                {
                    var entry = new Entry(parts[1], parts[2])
                    {
                        Date = parts[0]
                    };
                    entries.Add(entry);
                }
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}
        