using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public override void RecordEvent()
    {
        
    }

    public string GetTarget()
    {
        string target = $"0/{_target}";
        return target;
    }

    public void SetTarget()
    {
        Console.WriteLine("How many times will you perform this task? ");
        _target = int.Parse(Console.ReadLine());
        
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetBonus()
    {
        Console.WriteLine("Bonus points for goal completion: ");
        _bonus = int.Parse(Console.ReadLine());

    }

    public override bool IsComplete()
    {
        Console.WriteLine("Did you complete this goal (yes or no)? ");
        string goalStatus = Console.ReadLine();

        if (goalStatus == "yes")
        {
            _amountCompleted += 1;
            return true;
        } else {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        string goalDetails = $"[ ]{_shortName} ({_description}) --Currently Completed: {GetTarget()}";

        return goalDetails;
    }
}