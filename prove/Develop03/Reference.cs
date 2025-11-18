using System.Net.Http.Headers;

class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;
    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }
    public string GetBook()
    {
        return _book;
    }
    public string GetChapter()
    {
        return _chapter;
    }
    public string GetVerse()
    {
        return _startVerse + _endVerse;
    }
    public override string ToString()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}