using System.IO;

public abstract class Goal
{
    public string _title { get; set; }
    public int _points { get; set; }
    public string _description { get; set; }

    public abstract void DisplayGoal();
    public abstract void RecordEvent();
    public abstract void Save(StreamWriter writer);

    public virtual void InputGoal()
    {
        Console.Write("Enter title: ");
        _title = Console.ReadLine();
        Console.Write("Enter points: ");
        _points = int.Parse(Console.ReadLine());
        Console.Write("Enter description: ");
        _description = Console.ReadLine();
    }
}