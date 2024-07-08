using System;

public class BreathingActivity : Activity
{
    public BreathingActivity():base("Breathing", 0, "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void ActLoop()
    {
        DisplayWelcome();
        DefDuration();

        for (int i = 0; i < _duration; i += 4)
        {
            Console.WriteLine("Breath in...");
            CountDown(2);
            Console.WriteLine("Breathe out...");
            CountDown(2);
        }

        DisplayBye();
    }
}