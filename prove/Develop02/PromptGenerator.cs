using System.Dynamic;

class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What is the best thing you did today?",
        "What did you do to help someone today?",
        "What is a new skill you would like to develop?",
        "Who is someone who has made you a better person?",
        "What is an attribute you would like to gain in your life?"
    };

    public string GetRandomPrompt() 
    {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(5);
        string randomPrompt = _prompts[i];


        return randomPrompt;
    }
}