using System;
using System.Collections.Concurrent;
using System.Dynamic;

public class Word
{
    public string _text;
    public bool _isHidden;

    public void SetDisplayText(string text)
    {
        _text = text;
    }

    public string GetDisplayText()
    {
        string text = $"{_text}.";
        return text;
    }
}