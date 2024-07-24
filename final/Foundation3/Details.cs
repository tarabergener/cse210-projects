using System;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;

public class Details
{
    private Event _event;

    public void FullReceptionDetails()
    {
        Receptions receptions = new Receptions();
        Console.WriteLine($"{receptions.DisplayReceptionInfo}");
    }

    public void FullOutdoorDetials()
    {
        OutdoorGatherings outdoor = new OutdoorGatherings();
        Console.WriteLine($"{outdoor.DisplayOutdoorInfo}");
    }

    public void FullLectureDetails()
    {
        Lectures lectures = new Lectures();
        Console.WriteLine($"{lectures.DisplayLectureInfo}");
    }

    public void ShortDescription()
    {
        _event.GetEventTitle();
        _event.GetEventDate();
    }
}