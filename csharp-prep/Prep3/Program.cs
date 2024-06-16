using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int secretNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        Console.WriteLine("Guess the secret number between 1 and 100!");

        while (guess != secretNumber)
        {
            Console.Write("What is your guess? ");

            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (guess > secretNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (guess < secretNumber)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}