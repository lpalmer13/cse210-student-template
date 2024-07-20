using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2023, 11, 3), 60, 6),
            new Cycling(new DateTime(2023, 11, 4), 60, 15),
            new Swimming(new DateTime(2023, 11, 5), 60, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}