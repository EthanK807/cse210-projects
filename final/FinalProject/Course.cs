
class Course
{
    List<Hole> _holes;
    public Course()
    {
        Random random = new Random();
        for (int i = 0; i < 18; i++)
        {
            Hole hole = new Hole(this, random.Next(4) + 2);
        }
    }
    public Hole GetHole(int i)
    {
        return _holes[i];
    }

}