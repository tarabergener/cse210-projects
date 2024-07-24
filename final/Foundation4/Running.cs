using System;

public class Run : Exercise
{
    private int _distance;

    public void SetDistance(int distance)
    {
        _distance = distance;
    }

    //-----Distance in miles-----//
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