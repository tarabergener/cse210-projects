using System;
using System.ComponentModel;
using System.Data;

public class Activity
{
    private string _name = "";
    private string _description = "";
    protected int _duration;

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration()
    {
        Console.WriteLine($"How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public string DisplayName()
    {
        return $"Welcome to the {_name}";
    }

    public string DisplayDescription()
    {
        return $"This activity will help you {_description}";
    }

    public string DisplayEndingMessage()
    {
        return $"You have completed another {_duration} seconds of the {_name}.";
    }
}