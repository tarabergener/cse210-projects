using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

public class Scripture
{
    Reference _reference = new Reference("John", 3, 16);
    List<Word> _words;

    public Scripture(Reference _reference, string text)
    {
        text = 
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public static string GetDisplayText()
    {
        return ---;
    }

    public bool IsCompletelyHidden()
    {
        return ---; 
    }
}

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Text = text;
        _words = InitializeWords(text);
        _originalWords = new List<Word>(_words); // Store a copy of original words
    }
 
    private List<Word> InitializeWords(string text)
    {
        List<Word> words = new List<Word>();
        string[] tokens = text.Split(" ");
        foreach (var token in tokens)
        {
            words.Add(new Word(token));
        }
        return words;
    }
 
    public List<Word> GetWords()
    {
        return _words;
    }
 
    public void ResetWords()
    {
        // Reset words to original state
        _words = new List<Word>(_originalWords);
    }
}