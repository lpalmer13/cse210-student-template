using System;

public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflecting");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. View Activity Log");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();
            Activity activity = null;

            if (choice == "1")
            {
                activity = new BreathingActivity(GetDuration());
            }
            else if (choice == "2")
            {
                activity = new ReflectingActivity(GetDuration());
            }
            else if (choice == "3")
            {
                activity = new ListingActivity(GetDuration());
            }
            else if (choice == "4")
            {
                Log.DisplayLog();
                continue;
            }
            else if (choice == "5")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
                continue;
            }

            activity.ActLoop();
        }
    }

    static int GetDuration()
    {
        Console.WriteLine("Enter the duration in seconds:");
        int duration = int.Parse(Console.ReadLine());
        return duration;
    }
}