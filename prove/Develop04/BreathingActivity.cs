using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration)
        :base("Breathing", duration, "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void ActLoop()
    {
        DisplayWelcome();
        for (int i = 0; i < Duration; i += 6)
        {
            Console.WriteLine("Breath in...");
            CountDown(3);
            Console.WriteLine("Breathe out...");
            CountDown(3);
        }
        DisplayBye();
    }
}