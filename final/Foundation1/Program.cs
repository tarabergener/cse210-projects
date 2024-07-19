using System;

class Program
{
    static void Main(string[] args)
    {
        //------- Video 1 Information --------//
        Comment comm1 = new Comment();
        comm1.setName("George");
        comm1.setComment("This is the best movie of all time.");
        
        Comment comm2 = new Comment();
        comm2.setName("Annaliese");
        comm2.setComment("This is comedy gold!");

        Comment comm3 = new Comment();
        comm3.setName("Jeffrey");
        comm3.setComment("I don't know why everyone thinks this is so amazing...");
        
        Video video1 = new Video();
        video1.setTitle("TheGreatAnimal");
        video1.setAuthor("Janet Lewis");
        video1.setLength("350 seconds");

        video1._comments.Add(comm1);
        video1._comments.Add(comm2);
        video1._comments.Add(comm3);

        video1.Display();
        int _vid1Comments = video1._comments.Count;
        Console.WriteLine($"Number of comments: {_vid1Comments}");
        Console.WriteLine();

        //------- Video 2 Information --------//
        Comment comm4 = new Comment();
        comm4.setName("Jasmine");
        comm4.setComment("Whoa, that was a trippy video.");
        
        Comment comm5 = new Comment();
        comm5.setName("Paul");
        comm5.setComment("What an abstract work of art! New favorite video on YouTube!");

        Comment comm6 = new Comment();
        comm6.setName("Jasmine");
        comm6.setComment("I definitely wouldn't call it the best video on YouTube...");

        Comment comm7 = new Comment();
        comm7.setName("Paul");
        comm7.setComment("Are you kidding me?! This is the best video since the release of The Abstract Domain!");
        
        Video video2 = new Video();
        video2.setTitle("The Red Spot");
        video2.setAuthor("The Kalemine Brothers");
        video2.setLength("753 seconds");

        video2._comments.Add(comm4);
        video2._comments.Add(comm5);
        video2._comments.Add(comm6);
        video2._comments.Add(comm7);

        video2.Display();
        int _vid2Comments = video2._comments.Count;
        Console.WriteLine($"Number of comments: {_vid2Comments}");
        Console.WriteLine();


        //------- Video 3 Information --------//
        Comment comm8 = new Comment();
        comm8.setName("Zach");
        comm8.setComment("Short. Sweet. And to the point.");
        
        Comment comm9 = new Comment();
        comm9.setName("Paul");
        comm9.setComment("This is such an incredible work of art! So many different ways to interpret the meaning.");

        Comment comm10 = new Comment();
        comm10.setName("Cali");
        comm10.setComment("This would win the art show for sure!");

        Comment comm11 = new Comment();
        comm11.setName("Walton");
        comm11.setComment("I'm creeped out... I won't be sleeping tonight.");
        
        Video video3 = new Video();
        video3.setTitle("The Abstract Domain");
        video3.setAuthor("Wesley Chapel");
        video3.setLength("149 seconds");

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