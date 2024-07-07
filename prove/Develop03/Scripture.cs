Using.System;
Using.System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetRefernce());
        foreach (Word word in _words)
        {
            Console.WriteLine(word.GetString() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandom()
    {
        Random random = new Random();
        int index;
        do
        {
            index = random.Next(_words.Count);
        } while (_words[index].GetHidden());
        _words[index].HideWord();
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.GetHidden())
                return false;
        }
        return true;
    }
}