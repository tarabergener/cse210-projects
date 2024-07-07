using System;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

class BreathingActivity : Activity
{
    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine("Breathe in...");
            for (int i = _duration; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine("Now breathe out...");
            for (int i = _duration; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

        } else {
            DisplayEndingMessage();
        }
    }
}

