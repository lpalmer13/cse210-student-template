using System;
using System.IO;

public class EternalGoal : Goal
{
    private int _count;

    public EternalGoal(string title, string description, int points) : base(title, description, points)
    {
        _count = 0;
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"[Eternal] {_title} - {_description} - Points per event: {_points} - Times completed: {_count})");
    }
    public override void RecordEvent()
    {
        _count++;
        Console.WriteLine($"Event recorded for goal '{_title}'. Total completions: {_count}. Points earned: {_points * _count}");
    }
    public override void Save(StreamWriter writer)
    {
        writer.WriteLine("EternalGoal");
        writer.WriteLine(_title);
        writer.WriteLine(_description);
        writer.WriteLine(_points);
        writer.WriteLine(_count);
    }
    public override void Load(StreamReader reader)
    {
        _title = reader.ReadLine();
        _description = reader.ReadLine();
        _points = int.Parse(reader.ReadLine());
        _count = int.Parse(reader.ReadLine());
    }
}