using System;

public class WritingAssignment : Assignment
{
    private string _title = "";

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return $"Title: {_title} by {GetStudentName()}";
    }
}