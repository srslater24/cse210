using System;

class Program
{
    static void Main(string[] args)
    {
        // VARIABLES
        Random randomGenerator = new Random();
        int random_number = randomGenerator.Next(1, 100);
        int guess = 0;

        while (guess != random_number)
        {
            // GUESS INPUT
            Console.Write("What is your guess? ");
            string guess_string = Console.ReadLine();
            guess = int.Parse(guess_string);

            // LOWER OR HIGHER
            if (guess > random_number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < random_number)
            {
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine("You got it!");
    }
}