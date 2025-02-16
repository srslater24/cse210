using System;
using System.ComponentModel.DataAnnotations;

public class Word
{
    private string _word;
    private bool _hidden;

    public Word()
    {
        _word = "Default";
        _hidden = false;
    }

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void Display()
    {   
        //Display hidden word
        if (_hidden == true)
        {
            foreach (char letter in _word)
            {
                Console.Write("_");
            }
            Console.Write(" ");
        }
        //Display normal word
        else
        {
            Console.Write($"{_word} ");
        }
        
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }
}