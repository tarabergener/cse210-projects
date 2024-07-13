using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = true;
    
    public override void RecordEvent()
    {
        

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
        if (IsComplete() == true)
        {
            string taskComplete = $"Great job! You completed {_shortName}!You earned {_points} points!";
            return taskComplete;
        } else {
            string taskIncomplete = $"Keep up the great work! You will reach your goal soon!";
            return taskIncomplete;
        }
    }
}