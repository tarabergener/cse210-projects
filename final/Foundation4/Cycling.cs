using System;

public class Cycle : Exercise
{
    private double _distance;

    public void SetDistance(double distance)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / DisplayTime() * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}