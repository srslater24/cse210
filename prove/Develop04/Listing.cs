using System;

public class Listing : Activity
{
    private int _duration;

    private List<string> prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };

    public Listing() : base("Welcome to the Listing Activity.\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n", 
                              "Null")
    {
    }

    public void RunActivity() {
        DisplayWelcome();
        PromptDuration();
        _duration = GetDuration();
        ListingExercise(); 
    }

    public void ListingExercise()
    {
        Console.Clear();

        // Load
        Console.WriteLine("Get ready...");
        LoadScreen(5);

        // List instructions
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(1,4)];
        Console.WriteLine("\nList as many responses you can to the following prompt:");
        Console.WriteLine($" --- {prompt} --- ");
        Console.Write("\nYou may begin in: ");
        SmallTimer();
        Console.WriteLine("");

        // Start timer
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // List
        int listCount = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            listCount += 1;
        }

        // Finish
        Console.WriteLine($"You listed {listCount} items!");
        Console.WriteLine("\nWell done!");
        LoadScreen(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the Listing Activity");
        LoadScreen(5);
        Console.Clear();
    }

    public void SmallTimer()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}