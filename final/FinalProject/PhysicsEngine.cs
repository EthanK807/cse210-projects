using System.Security.Cryptography.X509Certificates;

class PhysicsEngine 
{
    private double _gravity;
    private double _windResistance;
        
    public PhysicsEngine(double windResistance) 
    {
        _gravity = -9.81;
        double _windResistance = windResistance;
    }
    public void updatePhysics(Ball ball, Hole hole)
    {
        // Update positions first
        ball.setX(ball.getXVel());
        ball.setY(ball.getYVel());

        // start with x axis
        double xNetForce = calculateAirResistence(ball, true);

        ball.setXVel(xNetForce);

        // now calculate y axis
        double yNetForce = 0;
        yNetForce += calculateAirResistence(ball, false);
        yNetForce += _gravity;

    }
    public double calculateAirResistence(Ball ball, bool horizontal)
    {
        double airDensity = 1.05;
        double dragCoefficient = 0.5;
        double crosssectionalArea = 0.0014;
        double beforeVelocity = 0.5 * airDensity * dragCoefficient * crosssectionalArea;
        if (horizontal)
        {
            if (ball.getXVel() > 0) 
            {
                return beforeVelocity * ball.getXVel() * -1;
            }
            else if (ball.getXVel() < 0)
            {
                return beforeVelocity * Math.Pow(ball.getXVel(), 2.0);
            }
            else
            {
                return 0;
            }
        } 
        else
        {
            if (ball.getYVel() > 0) 
            {
                return beforeVelocity * ball.getYVel() * -1;
            }
            else if (ball.getYVel() < 0)
            {
                return beforeVelocity * Math.Pow(ball.getYVel(), 2.0);
            }
            else
            {
                return 0;
            }
        }
    }
}