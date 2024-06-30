using System.ComponentModel.DataAnnotations;

public class Entry 
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display ()
    {

        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();

        PromptGenerator promptGenerator = new PromptGenerator();
        _promptText = promptGenerator.GetRandomPrompt();

        Console.WriteLine(_promptText);
        Console.WriteLine("Enter your passage here: ");
        _entryText = Console.ReadLine();
    
    }
    
}