public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }
    
    public string GetWord()
    {
        return _hidden ? "_____" : _word;
    }

    public void HideWord()
    {
        _hidden = true;
    }

    public bool GetHidden()
    {
        return _hidden;
    }
}