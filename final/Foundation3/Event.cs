using System;
using System.Dynamic;
using System.Net.Sockets;

public class Event
{
    private string _eventTitle;
    private string _description;
    private string _eventDate;
    private string _eventTime;
    private Address _address;

    public void SetEventTitle(string eventTitle)
    {
        _eventTitle = eventTitle;
    }

    public string GetEventTitle()
    {
        return _eventTitle;
    }

    public void SetEventDescription(string eventDescription)
    {
        _description = eventDescription;
    }

    public string GetEventDescription()
    {
        return _description;
    }

    public void SetEventDate(string eventDate)
    {
        _eventDate = eventDate;
    }

    public string GetEventDate()
    {
        return _eventDate;
    }

    public void SetEventTime(string eventTime)
    {
        _eventTime = eventTime;
    }

    public string GetEventTime()
    {
        return _eventTime;
    }

    public string GetEventAddress()
    {
        string eventAddress = _address.GetAddress();
        return eventAddress;
    }

    public void SetEventAddress(Address address)
    {
        _address = address;
    }

    public void GetEventInfo()
    {
        Console.WriteLine($"Event: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_eventDate}  Time: {_eventTime}");
        Console.WriteLine($"Location: {GetEventAddress()}");
    }
}