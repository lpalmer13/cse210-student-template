using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice;

        Console.WriteLine("Journal Program Start");
        do
        {
        
            Console.WriteLine("Welcome");
            Console.WriteLine("Display Menu");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    journal.WriteEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.LoadEntries();
                    break;
                case "4":
                    journal.SaveEntries();
                    break;
                case "5":
                    Console.WriteLine("Quitting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please select again.");
                    break;
            }
        } while (choice != "5");
    }
}  