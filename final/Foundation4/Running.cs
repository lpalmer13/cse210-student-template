using System;

public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / distance;
    }

    public override string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} Running ({Minutes} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}