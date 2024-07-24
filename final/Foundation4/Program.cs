using System;

class Program
{
    static void Main(string[] args)
    {
        Run r1 = new Run();
        r1.SetTime(36);
        r1.SetDistance(3);
        Console.WriteLine("Exercise: Running");
        Console.WriteLine($"Distance: {r1.GetDistance()} miles");
        Console.WriteLine($"Speed: {r1.GetSpeed()}mph");
        Console.WriteLine($"Pace: {r1.GetPace()} min per mile");
        r1.DisplayDate();
        Console.WriteLine($" Running ({r1.DisplayTime()} min): Distance {r1.GetDistance()} miles, Speed {r1.GetSpeed()}mph, {r1.GetPace()} min per mile");        
        Console.WriteLine();

        Cycle c1 = new Cycle();
        c1.SetTime(420);
        c1.SetDistance(147);
        Console.WriteLine("Exercise: Cycling");
        Console.WriteLine($"Distance: {c1.GetDistance()} miles");
        Console.WriteLine($"Speed: {c1.GetSpeed()}mph");
        Console.WriteLine($"Pace: {c1.GetPace()} min per mile");
        c1.DisplayDate();
        Console.WriteLine($" Running ({c1.DisplayTime()} min): Distance {c1.GetDistance()} miles, Speed {c1.GetSpeed()}mph, {c1.GetPace()} min per mile");
        Console.WriteLine();

        Swim s1 = new Swim();
        s1.SetTime(30);
        s1.SetLaps(10);
        Console.WriteLine("Exercise: Swimming");
        Console.WriteLine($"Distance: {s1.GetDistance()} km");
        Console.WriteLine($"Speed: {s1.GetSpeed()}kph");
        Console.WriteLine($"Pace: {s1.GetPace()} min per km");
        s1.DisplayDate();
        Console.WriteLine($" Running ({s1.DisplayTime()} min): Distance {s1.GetDistance()} km, Speed {s1.GetSpeed()}kph, {s1.GetPace()} min per km");
        Console.WriteLine();
    }
}