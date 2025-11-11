class Entry
{
    private string _date;
    private string _prompt;
    private string _response;
    public Entry(string _date, string _prompt, string _response)
    {
        this._date = _date;
        this._prompt = _prompt;
        this._response = _response;
    }
    public void toString()
    {
        Console.WriteLine($"{_date}#{_prompt}#{_response}");
    }
}