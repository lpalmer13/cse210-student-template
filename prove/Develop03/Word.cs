public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void SetWord(string word)
    {
        _word = word;
    }
    
    public string GetWord()
    {
        return _word;
    }

    public string GetString()
    {
        return _hidden ? "_____" : _words;
    }

    public bool GetHidden()
    {
        return _hidden;
    }

    public void HideWord()
    {
        _hidden = true;
    }
}