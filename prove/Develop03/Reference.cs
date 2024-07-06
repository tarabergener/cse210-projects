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

    public string GetDisplayText()
    {
        string r1 = $"{_book} {_chapter}:{_verse}";
        return r1;
    }
}