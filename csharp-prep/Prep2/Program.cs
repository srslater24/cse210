using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradestring = Console.ReadLine();
        int grade = int.Parse(gradestring);
        string letter = "Null";

        // LETTER GRADE
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Grade: {letter}");

        // PASS?
        if (grade >= 70)
        {
            Console.WriteLine("Result: Pass!");
        }
        else
        {
            Console.WriteLine("Result: Fail! Try studying harder next time!");
        }
    }
}