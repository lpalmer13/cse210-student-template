using System.IO;

public class FileHandler
{
    public static void SaveToFile(string filename, List<Entry> entries)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }
    }

    public static List<Entry> LoadFromFile(string filename)
    {
        List<Entry> entries = new List<Entry>();
        if (!File.Exists(filename))
        {
            return entries;
        }

        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    var entry = new Entry(parts[1], parts[2])
                    {
                        Date = parts[0]
                    };
                    entries.Add(entry);
                }
            }
        }
        return entries;
    }
}