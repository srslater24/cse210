using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        scripture.Display();
        Console.WriteLine();

        Thread.Sleep(8000); // 1000 milliseconds = 1 second
        Console.Clear();

        // Loop
        bool done = false;
        while (!done)
        {
            Console.Write("> ");
            string response = Console.ReadLine();

            //Quit program
            if (response == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            Console.Clear();

            //Else hide words
            for (int i=0;i<3;i++)
                scripture.HideWord();
            scripture.Display();
            done = scripture.IsFinished();

            Thread.Sleep(8000);
            Console.Clear();
        }
    }
}