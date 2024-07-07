using System;

public class ReflectionActivity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you felt close to God.",
        "Think of the last time you helped someone in need.",
        "Think about when you were young.",
        "Think about a time when your standards were tested.",
        "Think of a time when you found strength from someone you love.",
        "Think of an experience that made you stronger.",
        "Think of an experience that made you wiser.",
        "Think of a time when you had to stand for what was right alone.",
        "Consider a time when you to learn a new skill.",
        "Consider a time when you were humbled."
    };
    private List<string> _questions = new List<string>()
    {
        "How did you feel about this experience?",
        "What were some positive outcomes from this experience?",
        "How does this experience make you want to be better?"
    };

    public string GetRandomPrompt() 
    {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(10);
        string randomPrompt = _prompts[i];


        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(3);
        string randomQuestion = _questions[i];

        return randomQuestion;
    }
}