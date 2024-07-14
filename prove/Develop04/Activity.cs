using System;
using System.Threading;

public abstract class Activity
{
    private string _title;
    private int _duration;
    private string _welcome;
    

    public Activity(string title, int duration, string welcome)
    {
        _title = title;
        _duration = duration;
        _welcome = welcome;
    }

    public int Duration
    {
        get { return _duration; }
    }

    protected void Animation()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void DefDuration()
    {
        Console.Write($"Duration: {_duration} seconds");
    }

    protected void DisplayWelcome()
    {
        Console.WriteLine(_welcome);
        Console.WriteLine($"Activity: {_title}");
        DefDuration();
        Console.WriteLine("Prepare to begin...");
        Animation();
    }

    protected void DisplayBye()
    {
        Console.WriteLine("Good job");
        Console.WriteLine($"You have completed the {_title} activity.");
        Console.WriteLine($"Duration: {_duration} seconds");
        Animation();
    }

    protected void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    public abstract void ActLoop();
}