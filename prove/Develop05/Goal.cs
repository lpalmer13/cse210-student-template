using System;
using System.IO;

public abstract class Goal
{
    protected string _description;
    protected int _points;
    protected string _title;

    public Goal(string title, string description, int points)
    {
        _title = title;
        _description = description;
        _points = points;
    }
    public abstract void DisplayGoal();
    public abstract void RecordEvent();
    public abstract void Save(StreamWriter writer);
    public abstract void Load(StreamReader reader);

    public string Title => _title;
    public int Points => _points;
}