using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2023, 11, 4), 40, 3.0),
            new Cycling(new DateTime(2023, 11, 5), 45, 15.0),
            new Swimming(new DateTime(2023, 11, 6), 60, 30),
            new Running(new DateTime(2023, 11, 11), 45, 5.0),
            new Cycling(new DateTime(2023, 11, 12), 60, 18.0),
            new Swimming(new DateTime(2023, 11, 13), 75, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}