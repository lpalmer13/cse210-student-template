using System.IO;

class Eternal : Goal
{
    private int _count;

    public Eternal() { }

    public Eternal(string title, int points, int count)
    {
        _title = title;
        _points = points;
        _count = count;
    }
    public override void DisplayGoal()
    {
        Console.WriteLine($"{_title} - {_description} ({_points} points each time, recorded {_count} times)");
    }

    public override void RecordEvent()
    {
        _count++;
        Console.WriteLine($"{_title} Recourded {_count} times. You earned {_points} points.");
    }

    public override void Save(StreamWriter writer)
    {
        writer.WriteLine($"Eternal,{_title},{_points},{_count}");
    }
}