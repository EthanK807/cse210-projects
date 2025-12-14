using System.Security.Cryptography.X509Certificates;

class Ball
{
    private double _x;
    private double _y;
    private double _xVel;
    private double _yVel;
    private Player _player;
    public Ball(double x, double y, Player player)
    {
        _x = x;
        _y = y;
        _xVel = 0;
        _yVel = 0;
        _player = player;
    }
    public double getX()
    {
        return _x;
    }
    public double getY()
    {
        return _y;
    }
    public double getXVel()
    {
        return _xVel;
    }
    public double getYVel()
    {
        return _yVel;
    }
    public void setX(double x)
    {
        _x += x;
    }
    public void setY(double y)
    {
        _y += y;
    }
    public void setXVel(double x)
    {
        _xVel += x;
    }
    public void setYVel(double y)
    {
        _yVel += y;
    }

}