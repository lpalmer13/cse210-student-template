using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _listPrompts = new List<string>
    {
        "Who are people that you appriciate?",
        "What are personal stregths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", 0, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void ActLoop()
    {
        DisplayWelcome();
        DefDuration();

        Random random = new Random();
        Console.WriteLine(_listPrompts[random.Next(_listPrompts.Count)]);
        CountDown(5);

        List<string> items = new List<string>();
        for (int i = 0; i < _duration; i += 10)
        {
            Console.WriteLine("Enter an item: ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {items.Count} itemms.");
        DisplayBye();
    }
}