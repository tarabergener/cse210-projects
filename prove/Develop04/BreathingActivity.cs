using System;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

class BreathingActivity : Activity
{
    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("Breathe in...");
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.WriteLine();
            }

            Console.WriteLine("Now breathe out...");
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                Console.WriteLine();
            }
        }
        
        DisplayEndingMessage();
    }
}

