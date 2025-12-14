class Shot
{
    private double _startingX;
    private double _startingY;
    private double _endingX;
    private double __endingY;
    private Hole _hole;
    private Ball _ball;
    public Shot(Ball ball, Hole hole)
    {
        _hole = hole;
        _ball = ball;
    }
}