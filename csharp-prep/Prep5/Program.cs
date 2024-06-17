using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(squaredNumber, userName);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        
        return favNumber;
    }
    static int SquareNumber(int favNumber)
    {
        int squaredNumber = favNumber * favNumber;
        return squaredNumber;
    }
    static void DisplayResult(int squaredNumber, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
    }

}
    
