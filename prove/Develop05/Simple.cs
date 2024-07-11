using System.IO;

class Simple : Goal
{
    private bool _complete;

    public Simple() { }

    public Simple(string title, int points, bool complete)
    {
        _title = title;
        _points = points;
        _complete = complete;
    }

    public override void DisplayGoal()
    {
        string status = _complete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_title} - {_description} ({_points} points)");
    }

    public override void RecordEvent()
    {
        if (!_complete)
        {
            _complete = true;
            Console.WriteLine($"{_title} marked as complete. You earned {_points} points.");
        }
        else
        {
            Console.WriteLine($"{_title} is already complete.");
        }
    }
    
    public override void Save(StreamWriter writer)
    {
        writer.WriteLine($"Simple,{_title},{_points},{_complete}");
    }
}