using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        
        Activity breathing = new Activity();
        breathing.SetName("Breathing Activity");
        breathing.SetDescription("relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");


        Console.WriteLine(breathing.DisplayName());
        Console.WriteLine();
        Console.WriteLine(breathing.DisplayDescription());
        Console.WriteLine();
        breathing.SetDuration();
        breathing.GetDuration();



        Console.WriteLine();
        Console.WriteLine(breathing.DisplayEndingMessage());
    }

}