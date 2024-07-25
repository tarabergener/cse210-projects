using System;

class Program
{
    static void Main(string[] args)
    {
        //------- Video 1 Information --------//
        Comment comm1 = new Comment();
        comm1.SetName("George");
        comm1.SetComment("This is the best movie of all time.");
        
        Comment comm2 = new Comment();
        comm2.SetName("Annaliese");
        comm2.SetComment("This is comedy gold!");

        Comment comm3 = new Comment();
        comm3.SetName("Jeffrey");
        comm3.SetComment("I don't know why everyone thinks this is so amazing...");
        
        Video video1 = new Video();
        video1.SetTitle("TheGreatAnimal");
        video1.SetAuthor("Janet Lewis");
        video1.SetLength("350 seconds");

        video1._comments.Add(comm1);
        video1._comments.Add(comm2);
        video1._comments.Add(comm3);

        video1.Display();
        int _vid1Comments = video1._comments.Count;
        Console.WriteLine($"Number of comments: {_vid1Comments}");
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();

        //------- Video 2 Information --------//
        Comment comm4 = new Comment();
        comm4.SetName("Jasmine");
        comm4.SetComment("Whoa, that was a trippy video.");
        
        Comment comm5 = new Comment();
        comm5.SetName("Paul");
        comm5.SetComment("What an abstract work of art! New favorite video on YouTube!");

        Comment comm6 = new Comment();
        comm6.SetName("Jasmine");
        comm6.SetComment("I definitely wouldn't call it the best video on YouTube...");

        Comment comm7 = new Comment();
        comm7.SetName("Paul");
        comm7.SetComment("Are you kidding me?! This is the best video since the release of The Abstract Domain!");
        
        Video video2 = new Video();
        video2.SetTitle("The Red Spot");
        video2.SetAuthor("The Kalemine Brothers");
        video2.SetLength("753 seconds");

        video2._comments.Add(comm4);
        video2._comments.Add(comm5);
        video2._comments.Add(comm6);
        video2._comments.Add(comm7);

        video2.Display();
        int _vid2Comments = video2._comments.Count;
        Console.WriteLine($"Number of comments: {_vid2Comments}");
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();

        //------- Video 3 Information --------//
        Comment comm8 = new Comment();
        comm8.SetName("Zach");
        comm8.SetComment("Short. Sweet. And to the point.");
        
        Comment comm9 = new Comment();
        comm9.SetName("Paul");
        comm9.SetComment("This is such an incredible work of art! So many different ways to interpret the meaning.");

        Comment comm10 = new Comment();
        comm10.SetName("Cali");
        comm10.SetComment("This would win the art show for sure!");

        Comment comm11 = new Comment();
        comm11.SetName("Walton");
        comm11.SetComment("I'm creeped out... I won't be sleeping tonight.");
        
        Video video3 = new Video();
        video3.SetTitle("The Abstract Domain");
        video3.SetAuthor("Wesley Chapel");
        video3.SetLength("149 seconds");

        video3._comments.Add(comm8);
        video3._comments.Add(comm9);
        video3._comments.Add(comm10);
        video3._comments.Add(comm11);

        video3.Display();
        int _vid3Comments = video3._comments.Count;
        Console.WriteLine($"Number of comments: {_vid3Comments}");
        Console.WriteLine();
    }
}