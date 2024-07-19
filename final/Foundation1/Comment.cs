using System;
using System.Dynamic;

class Comment 
{
    private string _personName;
    private string _comment;

    public void setName(string personName)
    {
        _personName = personName;
    }

    public string getPersonName()
    {
        return _personName;
    }

    public void setComment(string comment)
    {
        _comment = comment;
    }

    public string getComment()
    {
        return _comment;
    }

    public void displayComments()
    {
        Console.WriteLine($"{_personName}: {_comment}");
    }
}