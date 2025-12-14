class Club
{
    private string _name;
    private double _loft;
    private double _power;
    public Club(string name, double loft, double power)
    {
        _name = name;
        _loft = loft;
        _power = power;
    }
    public string getName()
    {
        return _name;
    }
}