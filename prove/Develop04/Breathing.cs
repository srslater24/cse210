using System;

public class Breathing : Activity
{
    private int _duration;

    public Breathing() : base("Welcome to the Breathing Activity.\n\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n", 
                              "Null")
    {
    }

    public void RunActivity() {
        DisplayWelcome();
        PromptDuration();
        _duration = GetDuration();
        BreathingExercise(); 
    }

    public void BreathingExercise()
    {
        Console.Clear();

        // Load
        Console.WriteLine("Get ready...");
        LoadScreen(5);

        // Start timer
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Breathe in and out
        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreathe in...");
            SmallTimer();
            Console.Write("\nNow breathe out...");
            SmallTimer();
        }

        // Finish
        Console.WriteLine("\n\nWell done!");
        LoadScreen(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the Breathing Activity");
        LoadScreen(5);
        Console.Clear();
    }

    public void SmallTimer()
    {
        for (int i = 6; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}