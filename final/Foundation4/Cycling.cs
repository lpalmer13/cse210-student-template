using System;

public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int minutes, double speed, int farts)
        : base(date, minutes, farts)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed * Minutes) / 60;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        return 60 / speed;
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("MMMM dd, yyyy")} Cycling ({Minutes} min): Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile, Farts: {Farts}";
    }
}