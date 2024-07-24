using System;

public class Receptions : Event
{
    private int _rsvp;

    public void SetRsvp(int rsvp)
    {
        _rsvp = rsvp;
    }

    public int GetRsvp()
    {
        return _rsvp;
    }

    public void DisplayReceptionInfo()
    {
        Console.WriteLine($"Event: {GetEventTitle()}");
        Console.WriteLine($"Description: {GetEventDescription()}");
        Console.WriteLine($"Date: {GetEventDate()}  Time: {GetEventTime()}");
        Console.WriteLine($"Location: {GetEventAddress()}");
        Console.WriteLine($"RSVP Guests: {_rsvp}");
    }
}