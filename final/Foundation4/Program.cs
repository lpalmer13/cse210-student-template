using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2023, 11, 4), 40, 3.0, 2),
            new Cycling(new DateTime(2023, 11, 5), 45, 15.0, 3),
            new Swimming(new DateTime(2023, 11, 6), 60, 30, 1),
            new Running(new DateTime(2023, 11, 11), 45, 5.0, 4),
            new Cycling(new DateTime(2023, 11, 12), 60, 18.0, 2),
            new Swimming(new DateTime(2023, 11, 13), 75, 40, 5)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}