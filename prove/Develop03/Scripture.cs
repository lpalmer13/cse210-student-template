Using.System;
Using.System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    public void SetScripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    public string GetScripture()
    {
        return $"{_reference.GetRefernce()}: {string.Join(" ", _words.ConverAll(word => word.GetString()))}";
    }

    public void DisplayScripture()
    {
        Console.WriteLine(GetScripture());
    }

    public void HideRandom()
    {
        Random rand = new Random();
        int index = rand.Next(_words.Count);
        _words[index].HideWord();
    }
}