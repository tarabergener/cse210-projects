using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        Console.WriteLine($"{book} {chapter}:{verse}");
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
        Console.WriteLine($"{book} {chapter}:{startVerse}-{endVerse}");
    }

    public string GetDisplayText()
    {
        string r1 = $"{_book} {_chapter}:{_verse}";
        string r2 = $"{_book} {_chapter}:{_verse}-{_endVerse}";
        return r1;
    }
}