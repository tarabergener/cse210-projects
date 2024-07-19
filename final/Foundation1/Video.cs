using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

class Video
{
    private string _title;
    private string _author;
    private string _length;
    public List<Comment> _comments = new List<Comment>();

    public void setTitle(string title)
    {
        _title = title;
    }

    public string getTitle()
    {
        return _title;
    }

    public void setAuthor(string author)
    {
        _author = author;
    }

    public string getAuthor()
    {
        return _author;
    }

    public void setLength(string length)
    {
        _length = length;
    }

    public string getLength()
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
            comment.displayComments();
        }
    }
}