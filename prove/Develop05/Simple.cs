using System;
using System.IO;

public class SimpleGoal : Goal
{
    private bool _complete;

    public SimpleGoal(string title, string description, int points) : base(title, description, points)
    {
        _complete = false;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[Simple] {_title} - {_description} - Points: {_points} - Complete: {_complete}");
    }

    public override void RecordEvent()
    {
        if (!_complete)
        {
            _complete = true;
            Console.WriteLine($"Goal '{_title}' Completed! You earned {_points} points.");
        }
        else
        {
            Console.WriteLine($"Goal '{_title}' is already completed.");
        }
    }
    
    public override void Save(StreamWriter writer)
    {
        writer.WriteLine("SimpleGoal");
        writer.WriteLine(_title);
        writer.WriteLine(_description);
        writer.WriteLine(_points);
        writer.WriteLine(_complete);
    }
    public override void Load(StreamReader reader)
    {
        _title = reader.ReadLine();
        _description = reader.ReadLine();
        _points = int.Parse(reader.ReadLine());
        _complete = bool.Parse(reader.ReadLine());
    }
}