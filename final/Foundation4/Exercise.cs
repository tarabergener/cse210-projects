using System;
using System.ComponentModel;

public abstract class Exercise
{
    private string _date;
    private double _lengthTime;
    private List<string> _exercises;

    public void DisplayDate()
    {
        string todaysDate = DateTime.Now.ToString("M/d/yyyy");
        Console.Write(todaysDate);
    }

    //Length of time in minutes//
    public void SetTime(double lengthTime)
    {
        _lengthTime = lengthTime;
    }

    public double DisplayTime()
    {
        return _lengthTime;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

}