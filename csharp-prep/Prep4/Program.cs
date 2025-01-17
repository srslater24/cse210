using System;

class Program
{
    static void Main(string[] args)
    {
        // VARIABLES
        bool done = false;
        int total = 0;
        int largestNumber = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // LOOP INPUTS
        while (!done)
        {
            Console.Write("> ");
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                // EXIT
                done = true;
            } else
            {
                // ADD
                numbers.Add(number);
            }  
        }

        // CALCULATE SUM & LARGEST NUMBER
        foreach (int number in numbers)
        {
            total += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }
        Console.WriteLine($"Sum: {total}");

        // CALCULATE AVERAGE
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest Number: {largestNumber}");
    }
}