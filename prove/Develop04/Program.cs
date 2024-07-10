using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        int selection = 5;

        while (selection != 4)
        {

            if (selection == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.SetName("Breathing Activity");
                breathing.SetDescription("relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

                Console.WriteLine(breathing.DisplayName());
                Console.WriteLine();
                Console.WriteLine(breathing.DisplayDescription());
                Console.WriteLine();
                breathing.SetDuration();
                breathing.GetDuration();

                breathing.Run();
                Console.WriteLine();

                Console.WriteLine(breathing.DisplayEndingMessage());
                Console.WriteLine();

            } 
            
            else if (selection == 2)
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.SetName("Reflection Activity");
                reflection.SetDescription("reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

                Console.WriteLine(reflection.DisplayName());
                Console.WriteLine();
                Console.WriteLine(reflection.DisplayDescription());
                Console.WriteLine();
                reflection.SetDuration();
                reflection.GetDuration();

                Console.WriteLine(reflection.GetRandomPrompt());
                reflection.Run();
                Console.WriteLine();

                Console.WriteLine(reflection.DisplayEndingMessage());
                Console.WriteLine();
            }

            else if (selection == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.SetName("Listing Activity");
                listing.SetDescription("eflect on the good things in your life by having you list as many things as you can in a certain area.");

                Console.WriteLine(listing.DisplayName());
                Console.WriteLine();
                Console.WriteLine(listing.DisplayDescription());
                Console.WriteLine();
                listing.SetDuration();
                listing.GetDuration();

                Console.WriteLine(listing.GetRandomPrompt());

                Console.WriteLine(listing.DisplayEndingMessage());
                Console.WriteLine();
            }

            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Lisitng Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();

            Console.WriteLine("Please select from the following options:");
            string userInput = Console.ReadLine();
            selection = int.Parse(userInput);

        }

        Console.Write("Come back for more mindfullness acitvities!");

    }

}