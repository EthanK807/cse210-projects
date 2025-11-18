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
            int textIndex = _text.Length - 1;
            while (textIndex >= 0 && !char.IsLetterOrDigit(_text[textIndex]))
            {
                textIndex--;
            }
            
            string wordPart = _text.Substring(0, textIndex + 1);
            string punctuationPart = _text.Substring(textIndex + 1);
            
            return new string('_', wordPart.Length) + punctuationPart + " ";
        }
        else
        {
            return _text + " ";
        }
    }
    
    public void DisplayWord()
    {
        Console.WriteLine(_text);
    }
}