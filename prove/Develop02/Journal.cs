using System.IO;
using System.IO.Enumeration;

public class Journal 
{
    public List<Entry> _entries;
    
    public void AddEntry(List<Entry> _entries)
    {
        Console.Write("What would you like to call your file? ");
        string file = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
        }
    }

    public void DisplayAll()
    {


    }

    public static void SaveToFile()
    {
        string file = "";

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
            }
        }

    }

    public void LoadFromFile()
    {
        List<Entry> entries = new List<Entry>();
        string file = AddEntry(file);
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string _date = parts[0];
            string _promptText = parts[1];
            string _entryText = parts[2];

            _entries.Add
        }
    }
}