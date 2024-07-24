using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("1524 Jerry Ave", "Merrish", "Alabama", "United States");

        Receptions r1 = new Receptions();
        r1.SetEventTitle("Mary and Rick's Reception");
        r1.SetEventDescription("Receptions post wedding of Mary and Rick Sawsberger.");
        r1.SetEventDate("January 11, 2025");
        r1.SetEventTime("5:00pm");
        r1.SetRsvp(150);
        r1.SetEventAddress(a1);
        r1.GetEventInfo();
        Console.WriteLine("");
        r1.DisplayReceptionInfo();
        Console.WriteLine("");

        Address a2 = new Address("658658 Haddly Circle", "Hamsberry", "Minnesota", "United States");

        Lectures l2 = new Lectures();
        l2.SetEventTitle("Medical Professional's Seminar");
        l2.SetEventDescription("Seminar for medical professionals that specialize in treating different forms of cancer.");
        l2.SetSpeaker("Dr. Merril Monson & Dr. P. Haddish");
        l2.SetCapacity(500);
        l2.SetEventDate("October 24, 2024");
        l2.SetEventTime("7:00am");
        l2.SetEventAddress(a2);
        l2.GetEventInfo();
        Console.WriteLine("");
        l2.DisplayLectureInfo();
        Console.WriteLine("");

        Address a3 = new Address("15, rue Pierre Charron", "75008", "Paris", "France");

        OutdoorGatherings o3 = new OutdoorGatherings();
        o3.SetEventTitle("Louve Art Fundraiser Garden Party");
        o3.SetEventDescription("Garden party supporting artists old and new. Fundraising for renovations to the structure.");
        o3.SetEventDate("November 8, 2025");
        o3.SetEventTime("12:00pm");
        o3.SetEventAddress(a3);
        o3.GetEventInfo();
        Console.WriteLine("");

    }
}