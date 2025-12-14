using System.ComponentModel.DataAnnotations;

public enum SurfaceType 
    {
        Tee, Fairway, Rough, Sand, Green, Water
    }   
class Hole
{
    private Course _course;
    private List<SurfaceType> _surfaces;
    private int _par;
    private int _length;
    public Hole(Course course, int par)
    {
        Random random = new Random();
        _par = par;
        _course = course;
        switch (par)
        {
            case 3:
                _length = (int)NextGaussian(random, 155, 25);
                if (_length < 90)
                {
                    _length = 90;
                }
                else if (_length > 230)
                {
                    _length = 230;
                }
                break;
            case 4:
                _length = (int)NextGaussian(random, 330, 30);
                if (_length < 230)
                {
                    _length = 230;
                }
                else if (_length > 430)
                {
                    _length = 430;
                }
                break;
            case 5:
                _length = (int)NextGaussian(random, 515, 25);
                if (_length < 430)
                {
                    _length = 430;
                }
                else if (_length > 600)
                {
                    _length = 600;
                }
                break;
        }

        GenerateTerrain();

    }

    
    public void GenerateTerrain()
    {
        Random random = new Random();
        double startingHeight = NextGaussian(random, 50, 15);
        if (startingHeight < 0)
        {
            startingHeight = 0;
        }
        double endingHeight = NextGaussian(random, 50, 15);
        if (endingHeight < 0)
        {
            endingHeight = 0;
        }
        for (int i = 0; i < _length; i++)
        {
            
        }

    }

    // Written partially by Gemini but heavily edited by me
    private void GenerateSurfaceMap(Random random)
    {
        int i = 0;

        // 10 meters of rough
        for (; i < 10 && i < _length; i++) 
        {
            _surfaces[i] = SurfaceType.Rough;
        }
        // 5 meters for tee box
        for (; i < 15 && i < _length; i++) 
        {
            _surfaces[i] = SurfaceType.Tee;
        }
        // We need to leave space for the Green at the end 
        int endOfFairway = _length - 30;

        while (i < endOfFairway)
        {
            // Logic: Alternate Rough -> Fairway
            // 1. Rough Section (Short, 10-30m)
            int roughLen = random.Next(10, 30);
            bool isWater = random.NextDouble() < 0.20; 
            int waterLen = 0;

            if (isWater)
            {
                waterLen = (int)NextGaussian(random, 50, 20);
                for (int k = 0; k < waterLen && i < endOfFairway; k++, i++)
                {
                    _surfaces[i] = SurfaceType.Water;
                    roughLen--;
                }
            }
            
            {
                for (int k = 0; k < roughLen; k++)
                {
                    _surfaces[i] = SurfaceType.Rough;
                }
            }


            // 2. Fairway Section 
            // If we ran out of space in the loop above, break
            if (i >= endOfFairway) break;

            int fairwayLen = random.Next(30, 80);
            for (int k = 0; k < fairwayLen && i < endOfFairway; k++, i++)
            {
                _surfaces[i] = SurfaceType.Fairway;
            }
        }

        // Fill the remainder with Green
        for (; i < _length - 5; i++)
        {
            _surfaces[i] = SurfaceType.Green;
        }
        for (; i < _length; i++)
        {
            _surfaces[i] = SurfaceType.Rough;
        }
    }

    // Helper for Physics Engine later
    public float GetFriction(int x)
    {
        if (x < 0 || x >= _length) return 1.0f;
        
        switch (_surfaces[x])
        {
            case SurfaceType.Green: return 0.98f;
            case SurfaceType.Fairway: return 0.95f;
            case SurfaceType.Tee: return 1.0f;
            case SurfaceType.Rough: return 0.85f;
            case SurfaceType.Sand: return 0.60f;
            case SurfaceType.Water: return 0.0f;
            default: return 0.90f;
        }
    }

    // Written by Gemini, gives me a standard deviation of values instead of uniform random
    public static double NextGaussian(Random r, double mean, double stdDev)
    {
        // Generate two uniform random numbers between 0 and 1
        // We subtract from 1.0 to avoid getting 0.0 (which breaks Math.Log)
        double u1 = 1.0 - r.NextDouble(); 
        double u2 = 1.0 - r.NextDouble();

        // The Box-Muller Formula
        double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); 
        
        // Adjust center (mean) and width (stdDev)
        return mean + (stdDev * randStdNormal);
    }

}