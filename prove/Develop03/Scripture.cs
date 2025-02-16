using System;

// Proverbs 3:5-6 Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.

public class Scripture
{
    private List<Verse> _verses = new List<Verse> {};
    private Random _random = new Random();
    private string _reference;
    private string _scripture;

    public Scripture() //Default values
    {
        _reference = "Proverbs 3:5-6";
        _scripture = "Trust in the Lord with all thine heart and lean not unto thine own understanding;\nin all thy ways acknowledge him, and he shall direct thy paths.";
        string[] verses = _scripture.Split('\n');
        foreach (string verse in verses)
            _verses.Add(new Verse(verse.Trim()));
    }
    public Scripture(string reference, string scripture)
    {
        _reference = reference;
        _scripture = scripture;
        string[] verses = _scripture.Split('\n');
        foreach (string verse in verses)
            _verses.Add(new Verse(verse.Trim()));
    }

    public void Display()
    {
        Console.WriteLine(_reference);
        foreach (Verse verse in _verses)
            verse.Display();
    }

    public void HideWord()
    {
        int RandomIndex = _random.Next(0,_verses.Count);
        _verses[RandomIndex].HideWord();
    }

    public bool IsFinished()
    {
        foreach (Verse verse in _verses)
        {
            bool finished = verse.IsFinished();
            if (finished == false)
            {
                return false;
            }
        }
        return true;
    }
}