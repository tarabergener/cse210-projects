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
        List<string> options = new List<string> {"Write", "Display", "Load", "Save", "Quit"};
        List<int> numbers = new List<int> {1, 2, 3, 4, 5};

        int selection = -1;

        while (selection != 5) {

            foreach (string option in options)
            {
                Console.WriteLine($"{option}");
            }

            if (selection == 1) 
            {
                Entry entry = new Entry();
                entry.Display();

            }
            else if (selection == 2)
            {
                Journal dispEntry = new Journal();
                dispEntry.DisplayAll();
            }
            else if (selection == 3)
            {

            }
            else if (selection == 4)
            {
                Journal save = new Journal();
                save.SaveToFile()
            }

            Console.Write("Please select an option: ");
            string userInput = Console.ReadLine();

            selection = int.Parse(userInput);

        }
        
        Console.WriteLine("Great job writing in your journal today! See you tomorrow!");
    }
}