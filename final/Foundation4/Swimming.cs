using System;

public class Swim : Exercise
{
    private double _laps;

    public void SetLaps(double laps)
    {
        _laps = laps;
    }

    public double GetLaps()
    {
        return _laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / DisplayTime() * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}