using System;
using System.Collections.Generic;
using System.IO;

public class FileHandler
{
    public void Save(List<Entry> entries, string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date}~|~{entry.Prompt}~|~{entry.Response}");
            }
        }
    }

    public List<Entry> Load(string filename)
    {
        List<Entry> entries = new List<Entry>();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(new[] { "~|~" }, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    Entry entry = new Entry(parts[1], parts[2], parts[3]);
                    entries.Add(entry);
                }
            }
        }
        return entries;
    }
}