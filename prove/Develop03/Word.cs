class Word
{
    private Boolean _visibility;
    private string _text;
    public Word(string Word)
    {
        _visibility = true;
        _text = Word;
    }
    public void SetVisibility()
    {
        _visibility = false;
    }

    public Boolean GetVisibility()
    {
        return _visibility;
    }

    public string GetWordString()
    {
        if (!_visibility)
        {
            string newString = "";
            foreach (char c in _text)
            {
                newString += '_';
            }
            return newString;
        }
        else
        {
            return _text;
        }
    }
    
    public void DisplayWord()
    {
        Console.WriteLine(_text);
    }
}