using System;
using System.ComponentModel;

public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        string goalComplete = $"[ ] {_shortName} ({_description})";
    }

    public override bool IsComplete()
    {
        Console.WriteLine("Did you complete this goal (yes or no)? ");
        string goalStatus = Console.ReadLine();

        if (goalStatus == "yes")
        {
            return true;
        } else {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        string goalDetails = $"[ ]{_shortName} ({_description})";

        return goalDetails;
    }
}