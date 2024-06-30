using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        displayMessage();

        displayOptions();
        
    }

    static void displayMessage()
    {
        Console.WriteLine("Welcome to the Journal Program!");
    }

    static void displayOptions()
    {

        int selection = -1;

        Console.WriteLine("Please select a number: ");

        while (selection != 5) {

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            if (selection == 1) 
            {
                Entry entry = new Entry();
                entry.Display();

                Journal journal = new Journal();
                journal.AddEntry(_entries);
            }
            else if (selection == 2)
            {
                Journal dispEntry = new Journal();
                dispEntry.DisplayAll();
            }
            else if (selection == 3)
            {
                Journal load = new Journal();
                load.LoadFromFile();
            }
            else if (selection == 4)
            {
                Journal save = new Journal();
                save.SaveToFile()
            };

            Console.Write("Please select a number: ");
            string userInput = Console.ReadLine();

            selection = int.Parse(userInput);

        }
        
        Console.WriteLine("Great job writing in your journal today! See you tomorrow!");
    }
}