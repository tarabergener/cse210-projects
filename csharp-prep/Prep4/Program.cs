using System;
using System.Runtime.InteropServices.Marshalling;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            number = int.Parse(userInput);

            numbers.Add(number);
        }

        int sum = numbers.Sum();
        Console.WriteLine($"Sum: {sum}");

        double average = numbers.Average();
        Console.WriteLine($"Average: {average}");

        int largestNumber = numbers.Max();
        Console.WriteLine($"Largest Number: {largestNumber}");
    }
}