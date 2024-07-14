using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = true;
    
    public override void RecordEvent()
    {
        if (_isComplete == true)
        {
            string goalComplete = $"[X]{_shortName} ({_description})";
        }
    }

    public override bool IsComplete()
    {
        Console.WriteLine("Did you complete this goal (yes or no)? ");
        string goalStatus = Console.ReadLine();

        if (goalStatus == "yes")
        {
            return _isComplete;
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