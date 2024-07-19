using System;
using System.Dynamic;

class Comment 
{
    private string _personName;
    private string _comment;

    public void SetName(string personName)
    {
        _personName = personName;
    }

    public string GetPersonName()
    {
        return _personName;
    }

    public void SetComment(string comment)
    {
        _comment = comment;
    }

    public string GetComment()
    {
        return _comment;
    }

    public void DisplayComments()
    {
        Console.WriteLine($"{_personName}: {_comment}");
    }
}