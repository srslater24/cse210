using System;

public class Activity // base class
{
    private string _welcome;
    private string _goodbye;
    private int _duration; 

    public Activity()
    {

    }

    public Activity(string startMessage, string endMessage)
    {
        _welcome = startMessage;
        _goodbye = endMessage;
    }

    public void DisplayWelcome()
    {
        Console.Clear();
        Console.WriteLine(_welcome);
    }

    public void PromptDuration() {
        Console.Write("How long, in seconds, would you like for your session? ");
        string durationString = Console.ReadLine();
        _duration = Convert.ToInt32(durationString);
    }

    public void DisplayEnd() {
        Console.WriteLine(_goodbye);
    }

    public int GetDuration() {
        return _duration;
    }

    public void LoadScreen(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
    }
}