using System;

public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }

    public string GetSpeaker()
    {
        return _speaker;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void DisplayLectureInfo()
    {
        Console.WriteLine($"Event: {GetEventTitle()}");
        Console.WriteLine($"Description: {GetEventDescription()}.");
        Console.WriteLine($"Date: {GetEventDate()}  Time: {GetEventTime()}");
        Console.WriteLine($"Location: {GetEventAddress()}");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Max Guest Capacity: {_capacity}");
    }

    public void ShortLectureDescription()
    {
        Console.WriteLine("Category: Lecture");
        Console.WriteLine($"Event: {GetEventTitle()}");
        Console.WriteLine($"Date: {GetEventDate()}");
    }
}