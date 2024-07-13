using System;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Runtime.CompilerServices;

public class Scripture
{
    public Reference _reference = new Reference();
    public List<Word> _words = new List<Word>();

    public void DisplayWords()
    {
        foreach (Word w in _words)
        {
            string script = w._text;
            Console.WriteLine($"{script}.");
        }
    }

    public void HideRandomWords()
    {
        foreach (Word w in _words)
        {
            Random randomGenerator = new Random();
            randomGenerator.Next(_words.Count);
            string randomWord = w._text;
            string newWord = randomWord.Replace("_", "*");
        }
    }

    public void DisplayNewWords()
    {
        while (IsCompletelyHidden())
        {
            foreach(Word w in _words)
            {
                string script = w._text;
                Console.WriteLine($"{_words}");
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }

}