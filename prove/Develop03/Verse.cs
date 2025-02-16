using System;

public class Verse
{
    private Random _random = new Random();
    private List<Word> _words = new List<Word> {};

    private string _verse;

    public Verse() //Default
    {
        _verse = "Default verse";
        string[] words = _verse.Split(' ');
        foreach (string word in words)
            _words.Add(new Word(word.Trim()));
    }
    public Verse(string verse)
    {
        _verse = verse;
        string[] words = _verse.Split(' ');
        foreach (string word in words)
            _words.Add(new Word(word.Trim()));
    }

    public void Display()
    {
        foreach (Word word in _words)
            word.Display();
    }

    public void HideWord()
    {
        int RandomIndex = _random.Next(0,_words.Count);
        _words[RandomIndex].Hide();
    }

    public bool IsFinished()
    {
        foreach (Word word in _words)
        {
            bool hidden = word.IsHidden();
            if (hidden == false)
            {
                return false;
            }
        }
        return true;
    }
}