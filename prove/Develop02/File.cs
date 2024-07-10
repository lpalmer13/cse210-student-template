using System;
using System.Collections.Generic;
using System.IO;

public static class FileHandler
{
    public static void SaveToFile(List<Entry> entries, string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
    }

    public static List<Entry> LoadFromFile(string filename)
    {
        List<Entry> entries = new List<Entry>();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    entries.Add(new Entry(parts[1], parts[2], parts[0]));
                }
            }
        }
        return entries;
    }
}