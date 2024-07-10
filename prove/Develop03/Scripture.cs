public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    public Reference Reference => _reference;

    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetReference());
        foreach (var word in _words)
        {
            Console.Write(word.GetWord() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandom()
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(w => !w.GetHidden()).ToList();
        if (visibleWords.Count == 0)
        {
            Console.WriteLine("All words are already hidden.");
            return;
        }

        int index = random.Next(visibleWords.Count);
        visibleWords[index].HideWord();
    }

    public List<Word> GetHiddenWords()
    {
        return _words.Where(w => w.GetHidden()).ToList();
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.GetHidden());
    }
}