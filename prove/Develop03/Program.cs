using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Program
{
    private static Dictionary<string, List<Scripture>> scripturesByCategory = new Dictionary<string, List<Scripture>>();

    public static void InitializeScriptures()
    {

        try
        {
            string[] lines = File.ReadAllLines("Scriptures.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (parts.Length <6)
                {
                    Console.WriteLine($"Invalid format for line: {line}");
                    continue;
                }

                string category = parts[0];
                string book = parts[1];
                int chapter = int.Parse(parts[2]);
                int startVerse = int.Parse(parts[3]);
                int endVerse = int.Parse(parts[4]);
                string[] words = parts[5].Split(' ');
                List<Word> scriptureList = new List<Word>();
                foreach (string s in words)
                {
                    scriptureList.Add(new Word(s));
                }
                
                Reference reference = new Reference(book, chapter, startVerse, endVerse);
                Scripture scripture = new Scripture(reference, scriptureList);
                if (!scripturesByCategory.ContainsKey(category))
                {
                    scripturesByCategory[category] = new List<Scripture>();
                }
                scripturesByCategory[category].Add(scripture);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Scriptures.txt not found. Please create the file with scriptures.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading Scriptures.txt: {ex.Message}");
        }
    }

    public static void ScriptureLoop()
    {
        InitializeScriptures();

        if (scripturesByCategory.Count == 0)
        {
            Console.WriteLine("No scriptures found. Exiting program.");
            return;
        }

        while (true)
        {
            Console.WriteLine("Select a category:");
            int categoryIndex = 1;
            Dictionary<int, string> categoryMap = new Dictionary<int, string>();
            foreach (var category in scripturesByCategory.Keys)
            {
                Console.WriteLine($"{categoryIndex}. {category}");
                categoryMap[categoryIndex] = category;
                categoryIndex++;
            }
            Console.WriteLine("0. Exit");

            int selectedCategoryIndex;
            while (true)
            {
                Console.Write("Enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out selectedCategoryIndex) && selectedCategoryIndex >= 0 && selectedCategoryIndex <=categoryMap.Count)
                {
                    break;
                }
                Console.WriteLine("Invalid choice. Please enter a number from the menu.");
            }

            if (selectedCategoryIndex == 0)
            {
                break;
            }

            string selectedCategory = categoryMap[selectedCategoryIndex];

            var scriptures = scripturesByCategory[selectedCategory];
            Console.WriteLine($"Select a scripture from {selectedCategory}:");
            for (int i = 0; i < scriptures.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {scriptures[i].Reference.GetReference()}");
            }
            Console.WriteLine("0. Back to categories");
            
            int selectedScriptureIndex;
            while (true)
            {
                Console.Write("Enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out selectedScriptureIndex) && selectedScriptureIndex >= 0 && selectedScriptureIndex <= scriptures.Count)
                {
                    break;
                }
                Console.WriteLine("Invalid choice. Please enter a number from the menu.");
            }

            if (selectedScriptureIndex == 0)
            {
                continue;
            }

            var selectedScripture = scriptures[selectedScriptureIndex - 1];
            while (true)
            {
                Console.Clear();
                selectedScripture.DisplayScripture();
                if (selectedScripture.AllWordsHidden())
                {
                    Console.WriteLine("All words are hidden. Exiting.");
                    break;
                }
                Console.WriteLine("Press Enter to hide a word, or type 'quit' to exit.");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                selectedScripture.HideRandom();
                Console.Clear();
                selectedScripture.DisplayScripture();
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
        }
    }

    public static void Main(string[] args)
    {
        ScriptureLoop();
    }
}