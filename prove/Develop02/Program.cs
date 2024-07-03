using System;

public class Program
{
    private static Journal journal = new Journal();
    private static PromptGenerator promptGenerator = new PromptGenerator();

    public static void Main(string[] args)
    {
        Console.WriteLine("Journal Program Start");
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    journal.AddEntry(promptGenerator.GetRandomPrompt());
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.LoadFromFile();
                    break;
                case "4":
                    journal.SaveToFile();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    private static void DisplayMenu()
    {
        Console.WriteLine("\nWelcome to the Journal Program");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Load the jounal from a file");
        Console.WriteLine("4. Save the journal to a file");
        Console.WriteLine("5. Quit");
        Console.Write("Choose an option: ");
    }
}   