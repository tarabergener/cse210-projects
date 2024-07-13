using System;

class Program
{
    static void Main(string[] args)
    {
        int selection = 0;

        while (selection != 6)
        {
            if (selection == 1)
            {
                
            }

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine();

            Console.WriteLine("Please select from the following options:");
            string userInput = Console.ReadLine();
            selection = int.Parse(userInput);
        }
    }
}