using System;
using System.IO;

public class CheckListGoal : Goal
{
    private int _count;
    private int _targetCount;
    private int _bonusPoints;

    public CheckListGoal(string title, string description, int points, int targetCount, int bonusPoints) : base(title, description, points)
    {
        _count = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[CheckList] {_title} - {_description} - Points per event: {_points} - Times completed: {_count}/{_targetCount} - Bonus: {_bonusPoints}");
    }

    public override void RecordEvent()
    {
        _count++;
        if (_count >= _targetCount)
        {
            Console.WriteLine($"Checklist goal '{_title}' completed! You earned {_points * _targetCount + _bonusPoints} points in total.");
        }
        else
        {
            Console.WriteLine($"Event recorded for goal '{_title}'. Total completions: {_count}/{_targetCount}. Points earned: {_points * _count}");
        }
    }
    
    public override void Save(StreamWriter writer)
    {
        writer.WriteLine("CheckListGoal");
        writer.WriteLine(_title);
        writer.WriteLine(_description);
        writer.WriteLine(_points);
        writer.WriteLine(_count);
        writer.WriteLine(_targetCount);
        writer.WriteLine(_bonusPoints);
    }
    public override void Load(StreamReader reader)
    {
        _title = reader.ReadLine();
        _description = reader.ReadLine();
        _points = int.Parse(reader.ReadLine());
        _count = int.Parse(reader.ReadLine());
        _targetCount = int.Parse(reader.ReadLine());
        _bonusPoints = int.Parse(reader.ReadLine());
    }
}