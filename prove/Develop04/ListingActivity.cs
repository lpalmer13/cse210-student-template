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

    public ListingActivity(int duration)
        : base("Listing", 0, "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void ActLoop()
    {
        DisplayWelcome();
        Random random = new Random();
        string prompt = _listPrompts[random.Next(_listPrompts.Count)];
        Console.WriteLine(prompt);
        Animation();

        List<string> items = new List<string>();
        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine("Enter an item: ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} itemms.");
        DisplayBye();
    }
}