using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    private static List<Goal> goals = new List<Goal>();
    private static int totalPoints = 0;

    public static void Main()
    {
        Menu();
    }

    public static void Menu()
    {
        while (true)
        {
            Console.WriteLine("\nEternal Quest");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            int Choice = int.Parse(Console.ReadLine());

            switch (Choice)
            {
               case 1:
                    SubMenu();
                    break;
                case 2:
                    RecordEvent();
                    break;
                case 3:
                    DisplayGoals();
                    break;
                case 4:
                    SaveGoals();
                    break;
                case 5:
                    LoadGoals();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
    
    public static void SubMenu()
    {
        Console.WriteLine("\nCreate New Goal");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choose a type: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Enter the title: ");
        string title = Console.ReadLine();
        Console.Write("Enter the description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points: ");
        int points = int.Parse(Console.ReadLine());
        
        switch (type)
        {
            case 1:
                goals.Add(new SimpleGoal(title, description, points));
                break;
            case 2: 
                goals.Add(new EternalGoal(title, description, points));
                break;
            case 3:
                Console.Write("Enter the target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new CheckListGoal(title, description, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    public static void RecordEvent()
    {
        Console.WriteLine("\nRecord Event");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Title}");
        }
        Console.Write("Choose a goal to record an event: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < goals.Count)
        {
            goals[choice].RecordEvent();
            totalPoints += goals[choice].Points;
            Console.WriteLine($"Total points: {totalPoints}");
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    public static void DisplayGoals()
    {
        Console.WriteLine("\nDisplay Goals");
        foreach (var goal in goals)
        {
            goal.DisplayGoal();
        }
        Console.WriteLine($"Total Points: {totalPoints}");
    }

    public static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(totalPoints);
            foreach (var goal in goals)
            {
                goal.Save(writer);
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public static void LoadGoals()
    {
        goals.Clear();
        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            totalPoints = int.Parse(reader.ReadLine());
            while (!reader.EndOfStream)
            {
                string type = reader.ReadLine();
                Goal goal = null;

                switch (type)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal("", "", 0);
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal("", "", 0);
                        break;
                    case "CheckListGoal":
                        goal = new CheckListGoal("", "", 0, 0, 0);
                        break;
                }

                goal?.Load(reader);
                if (goal != null)
                {
                    goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }
}
