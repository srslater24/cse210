using System;

public class Comment
{
    private string _username;
    private string _text;

    public Comment(string username, string text)
    {
        _username = username;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"Commenter Username: {_username}");
        Console.WriteLine($"Text: {_text}");
        Console.WriteLine();
    }
}