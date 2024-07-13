using System;

public class Reference
{
    public string _book;
    public int _chapter;
    public int _verse;

    public void SetDisplayText(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string GetDisplayText()
    {
        string r1 = $"{_book} {_chapter}:{_verse}";
        return r1;
    }
}