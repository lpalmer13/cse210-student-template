using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static Scripture tempScripture;

    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScripturesFromFile("Scriptures.txt");
        Random rand = new Random();
        tempScripture = scriptures[rand.Next(scriptures.Count)];
        ScriptureLoop();
    }

    static List<Scripture> LoadScripturesFromFile(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();

        foreach (var line in File.ReadAllLines(filePath))
        {
            var parts = line.Split(';');
            var reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), parts.Length > 4 ? int.Parse(parts[3]) : int.Parse(parts[2]));
            var words = new List<Word>();
            foreach (var word in parts[4].Split(' '))
            {
                words.Add(new Word(word));
            }
            scriptures.Add(new Scripture(reference, words));
        }

        return scriptures;  
    }

    static void ScriptureLoop()
    {
        while (true)
        {
            Console.Clear();
            tempScripture.DisplayScripture();
            Console.WriteLine("\nPress Enter to hide words or type 'quit to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            tempScripture.HideRandom();
            if (tempScripture.AllWordsHidden())
                break;
        }
    }
}