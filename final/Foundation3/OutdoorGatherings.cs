using System;

public class OutdoorGatherings : Event
{
    private string _weather;

    public void SetWeather(string weather)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }
    
    public void DisplayOutdoorInfo()
    {
        Console.WriteLine($"Event: {GetEventTitle()}");
        Console.WriteLine($"Description: {GetEventDescription()}.");
        Console.WriteLine($"Date: {GetEventDate()}  Time: {GetEventTime()}");
        Console.WriteLine($"Location: {GetEventAddress()}");
        Console.WriteLine($"Weather: {_weather}");
    }
}