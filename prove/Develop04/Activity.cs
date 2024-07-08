using System;
using System.Threading;
using System.Collections.Generic;

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

    public void Animation()
    {
        Console.Write(".");
        Thread.Sleep(500);
    }

    public void DefDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayWelcome()
    {
        Console.WriteLine($"Welcome to the {_title} activity!");
        Console.WriteLine(_welcome);
        Console.WriteLine("Prepare to begin...");
        CountDown(5);
    }

    public void DisplayBye()
    {
        Console.WriteLine("Good job");
        CountDown(3);
        Console.WriteLine($"You have completed the {_title} activity for {_duration} seconds.");
        CountDown(3);
    }

    public void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public abstract void ActLoop();
}