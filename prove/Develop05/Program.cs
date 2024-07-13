using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;
    static int streak = 0;
    static DateTime lastRecordDate = DateTime.MinValue;

    public static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu()
    {   
        Console.WriteLine("Welcome to the Eternal Quest Program!");
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nMain Menu");
            Console.WriteLine("  1. Display Goals");
            Console.WriteLine("  2. Create New Goal");
            Console.WriteLine("  3. Record Event");
            Console.WriteLine("  4. Display Score");
            Console.WriteLine("  5. Display Streak");
            Console.WriteLine("  6. Save Goals");
            Console.WriteLine("  7. Load Goals");
            Console.WriteLine("  8. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                DisplayGoals();
            }
            else if (choice == "2")
            {
                SubMenu();
            }
            else if (choice == "3")
            {
                RecordEvent();
            }
            else if (choice == "4")
            {
                DisplayScore();
            }
            else if (choice == "5")
            {
                DisplayStreak();
            }
            else if (choice == "6")
            {
                Save();
            }
            else if (choice == "7")
            {
                Load();
            }
            else if (choice == "8")
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select again.");
            }
        }
    }
    
    public static void SubMenu()
    {
        Console.WriteLine("\nCreate New Goal");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Select an option: ");
        string choice = Console.ReadLine();

        Goal newGoal = null;
        if (choice == "1")
        {
            newGoal = new Simple();
        }
        else if (choice == "2")
        {
            newGoal = new Eternal();
        }
        else if (choice == "3")
        {
            newGoal = new CheckList();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select again.");
            return;
        }
        newGoal.InputGoal();
        goals.Add(newGoal);
    }

    public static void DisplayGoals()
    {
        Console.WriteLine("\nDisplay Goals");
        foreach (var goal in goals)
        {
            goal.DisplayGoal();
        }
        DisplayScore();
    }

    public static void RecordEvent()
    {
        Console.WriteLine("\nRecord Event");
        Console.Write("Enter goal title: ");
        string title = Console.ReadLine();
        foreach (var goal in goals)
        {
            if (goal._title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                goal.RecordEvent();
                totalPoints += goal._points;
                UpdateStreak();
                return;
            }
        }
        Console.WriteLine("Goal not found.");
    }

    public static void DisplayScore()
    {
        Console.WriteLine($"\nYou have {totalPoints} points.");
    }

    public static void DisplayStreak()
    {
        Console.WriteLine($"\nCurrent Streak: {streak} days");
    }

    private static void UpdateStreak()
    {
        DateTime today = DateTime.Today;
        if (lastRecordDate == DateTime.MinValue || lastRecordDate < today)
        {
            if (lastRecordDate.AddDays(1) == today)
            {
                streak++;
            }
            else
            {
                streak = 1;
            }
            lastRecordDate = today;
        }
    }
    
    public static void Save()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine($"Total Score: {totalPoints}");
            writer.WriteLine($"Daily Streak: {streak}");
            foreach (var goal in goals)
            {
                goal.Save(writer);
            }
        }
        Console.WriteLine("Goals saved.");
    }

    public static void Load()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                string totalPointsLine = reader.ReadLine();
                if (totalPointsLine != null && totalPointsLine.StartsWith("Total Score: "))
                {
                    totalPoints = int.Parse(totalPointsLine.Substring("Total Score: ".Length));
                }

                string streakLine = reader.ReadLine();
                if (streakLine != null && streakLine.StartsWith("Daily Streak: "))
                {
                    streak = int.Parse(streakLine.Substring("Daily Streak: ".Length));
                }

                goals.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    Goal goal = null;
                    if (parts[0] == "Simple")
                    {
                        goal = new Simple(parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
                    }
                    else if (parts[0] == "Eternal")
                    {
                        goal = new Eternal(parts[1], int.Parse(parts[2]), int.Parse(parts[3]));
                    }
                    else if (parts[0] == "CheckList")
                    {
                        goal = new CheckList(parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));
                    }
                    if (goal != null) goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }
}