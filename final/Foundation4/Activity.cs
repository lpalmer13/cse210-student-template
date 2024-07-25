using System;

public abstract class Activity
{
    private DateTime date;
    private int minutes;
    private int farts;

    public Activity(DateTime date, int minutes, int farts)
    {
        this.date = date;
        this.minutes = minutes;
        this.farts = farts;
    }

    public DateTime Date => date;
    public int Minutes => minutes;
    public int Farts => farts;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date.ToString("MMMM dd, yyyy")} ({Minutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile, Farts: {Farts}";
    }
}