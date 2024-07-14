using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    public void Start()
    {
        
    }

    public void DisplayPlayerInfo()
    {

        Console.WriteLine($"Your current score is ...");
    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {
        SimpleGoal sGoal = new SimpleGoal();
        sGoal.SetName();
        sGoal.SetDescription();
        sGoal.SetPoints();
        Console.WriteLine($"[ ] {sGoal.GetName()} = {sGoal.GetPoints()}");
        string g1 = $"{sGoal.GetName()}, {sGoal.GetDescription()}, {sGoal.GetPoints()}";


    }

    public void RecordEvent()
    {
        
    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {

    }

}