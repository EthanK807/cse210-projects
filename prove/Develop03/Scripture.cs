class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ';', ':', '\n', '\r', '\t' };

        List<string> tempList = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();

        foreach (string word in tempList)
        {
            Word word1 = new Word(word);
            _words.Append(word1);
        }
    }
    public void DisplayScripture()
    {
        Console.WriteLine($"{_reference.ToString()}\n");
        foreach (Word word in _words)
        {
            Console.WriteLine(word.GetWordString());
        }
    }
    public Reference GetReference()
    {
        return _reference;
    }
    public List<Word> GetWords()
    {
        return _words;
    }
    public void HideWords()
    {
        Random rnd = new Random();
        if (GetHiddenCount() < 3)
        {
            foreach (Word word in _words)
            {
                if (!word.GetVisibility())
                {
                    word.SetVisibility();
                }
            }
        }
        else
        {
            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    int randomWord = rnd.Next(0, _words.Count);
                    if (!_words[randomWord].GetVisibility())
                    {
                        _words[randomWord].SetVisibility();
                        break;
                    }
                }
            }

        }
    }
    public int GetHiddenCount()
    {
        int hiddenCount = 0;
        foreach (Word word in _words)
        {
            if (!word.GetVisibility())
            {
                hiddenCount++;
            }
        }
        return hiddenCount;
    }
}