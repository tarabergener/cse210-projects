using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizing App! Today we are memorizing John 3:16.");
        Console.WriteLine("Hit enter to remove random words from the scripture.");
        Console.WriteLine();
        Reference reference = new Reference();
        reference.SetDisplayText("John", 3, 16);
        Console.WriteLine(reference.GetDisplayText());

        Word word = new Word();
        word._text = "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life";
        
        Scripture scripture = new Scripture();
        scripture._words.Add(word);
        scripture.DisplayWords();
        Console.WriteLine();
        Console.WriteLine("Hit enter to remove random words from the scripture.");

        scripture.HideRandomWords();






    }
}