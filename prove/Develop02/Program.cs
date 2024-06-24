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

        int selection = 1;

        while (selection != 5) {

            for (int i = 1; i = options; i++) {

                Console.WriteLine(i);
            }

            Console.Write("Please select an option: ");
            string userInput = Console.ReadLine();

            selection = int.Parse(userInput);
        }
    }
}