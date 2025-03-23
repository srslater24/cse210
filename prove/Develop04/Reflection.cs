using System;

public class Reflection : Activity
{
    private int _duration;

    private List<string> prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        };
    
    private List<string> questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        };

    public Reflection() : base("Welcome to the Reflecting Activity.\n\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n", 
                              "Null")
    {
    }

    public void RunActivity() {
        DisplayWelcome();
        PromptDuration();
        _duration = GetDuration();
        ReflectionExercise(); 
    }

    public void ReflectionExercise()
    {
        Console.Clear();

        // Load
        Console.WriteLine("Get ready...");
        LoadScreen(5);

        // Consider prompt
        Random rnd = new Random();
        string prompt = prompts[rnd.Next(1,4)];
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($" --- {prompt} --- ");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine(); // Wait for input
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        SmallTimer();
        Console.Clear();

        // Start timer
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        // Questions
        while (DateTime.Now < endTime)
        {
            rnd = new Random();
            string question = questions[rnd.Next(1,9)];
            Console.Write($"\n> {question} ");
            LoadScreen(10);
        }

        // Finish
        Console.WriteLine("\n\nWell done!");
        LoadScreen(5);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the Reflecting Activity");
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