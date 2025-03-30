using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    public List<Comment> _comments = new List<Comment> {};

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void DisplayAll()
    {
        Console.WriteLine("-------------------// Video //-------------------");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine("-----------------// Comments //-----------------\n");
        foreach (Comment comment in _comments)
            comment.Display();
        Console.WriteLine($"Comment Count: {ReturnComments()}");
        Console.WriteLine("------------------------------------------------\n\n");
    }

    public int ReturnComments()
    {
        return _comments.Count;
    }

    public void AddComment(string username, string text)
    {
        Comment comment = new Comment(username, text);
        _comments.Add(comment);
    }
}