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
        string _promptText = promptGenerator.GetRandomPrompt();

        Console.WriteLine(_promptText);
        Console.WriteLine("Enter your passage here: ");
        string _entryText = Console.ReadLine();

        Console.WriteLine($"Date: {_date}");
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);
        Console.WriteLine("");

        Journal.AddEntry(_entries)
    }
    
}