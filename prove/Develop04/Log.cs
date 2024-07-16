using System;
using System.IO;

public static class Log
{
    private static string logFilePath = "ActivityLog.txt";

    public static void LogActivity(string activityName, int duration)
    {
        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine($"{DateTime.Now}: {activityName} for {duration} seconds");
        }
    }

    public static void DisplayLog()
    {
        if (File.Exists(logFilePath))
        {
            string[] logEntries = File.ReadAllLines(logFilePath);
            foreach (var entry in logEntries)
            {
                Console.WriteLine(entry);
            }
        }
        else
        {
            Console.WriteLine("No log entries found.");
        }
    }
}