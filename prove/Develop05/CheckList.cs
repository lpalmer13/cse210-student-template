using System.IO;

class CheckList : Goal
{
    private int _count;
    private int _target;

    public CheckList() { }

    public CheckList(string title, int points, int count, int target)
    {
        _title = title;
        _points = points;
        _count = count;
        _target = target;
    }

    public override void DisplayGoal()
    {
        string status = _count >= _target ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_title} - {_description} ({_points} points each time, {_count}/{_target} times completed)");
    }

    public override void RecordEvent()
    {
        if (_count < _target)
        {
            _count++;
            Console.WriteLine($"{_title} recorded {_count}/{_target} times. You earned {_points} points.");
            if (_count == _target)
            {
                Console.WriteLine($"Congratulations! You completed {_title} and earned a bonus of {_points * _target} points.");
            }
        }
        else
        {
            Console.WriteLine($"{_title} is already complete.");
        }
    }
    
    public override void Save(StreamWriter writer)
    {
        writer.WriteLine($"CheckList,{_title},{_points},{_count},{_target}");
    }

    public override void InputGoal()
    {
        base.InputGoal();
        Console.Write("Enter target count: ");
        _target = int.Parse(Console.ReadLine());
    }
}