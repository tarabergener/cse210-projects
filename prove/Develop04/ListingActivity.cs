using System;
using System.ComponentModel;
using System.Dynamic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(5);
        string randomPrompt = _prompts[i];

        return randomPrompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--{GetRandomPrompt()}--");
    }

    public List<string> GetListFromUser = new List<string>();

    public void GetList()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine();
            string list1 = Console.ReadLine();
            GetListFromUser.Add(list1);
        }
    }
}