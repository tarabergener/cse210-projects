using System;
using System.Reflection.Metadata.Ecma335;

public abstract class Goal
{
    protected string _shortName;
    private string _description;
    protected string _points;

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public string GetDetailsString()
    {
        string goalDetails = $"{_shortName}; {_description}; {_points}";

        return goalDetails;
    }

    public void SetDetailsString(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public abstract string GetStringRepresentation();
}
