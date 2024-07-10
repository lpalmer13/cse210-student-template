using System;

public class Program
{
    static Journal journal = new Journal();

    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayMenu();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Journal Program!");
    }

    static void DisplayMenu()
    {   
        while (true)
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.WriteEntry();
            }
            else if (choice == "2")
            {
                 journal.DisplayJournal();
            }
            else if (choice == "3")
             {
                Console.Write("Enter filename to save: ");
                string saveFilename = Console.ReadLine();
                journal.SaveJournal(saveFilename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename to load: ");
                string loadFilename = Console.ReadLine();
                journal.LoadJournal(loadFilename);
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}  