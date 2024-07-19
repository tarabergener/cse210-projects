using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

class Video
{
    private string _title;
    private string _author;
    private string _length;
    public List<Comment> _comments = new List<Comment>();

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetLength(string length)
    {
        _length = length;
    }

    public string GetLength()
    {
        return _length;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_length}");
        Console.WriteLine();
        Console.WriteLine("Comments: ");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComments();
        }
    }
}