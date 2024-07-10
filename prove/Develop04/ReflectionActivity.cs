using System;

public class ReflectionActivity : Activity
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
        "Consider a time when you were humbled.",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "How did you feel about this experience?",
        "What were some positive outcomes from this experience?",
        "How does this experience make you want to be better?",
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < futureTime)
        {
            DisplayQuestion();
            for (int i = 10; i > 0; i--)
            {
                Console.Write(".");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
    }

    public string GetRandomPrompt() 
    {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(14);
        string randomPrompt = _prompts[i];


        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(12);
        string randomQuestion = _questions[i];

        return randomQuestion;
    }

    public void DisplayQuestion()
    {
        Console.WriteLine($"*{GetRandomQuestion()}");
    }
}