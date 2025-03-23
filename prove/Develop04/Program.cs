using System;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        // Setup
        Menu menu = new Menu();

        // Begin loop
        string choice = "Null";
        while (choice != "4")
        {
            menu.Display();
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                var breathing = new Breathing();
                breathing.RunActivity();
            }
            else if (choice == "2")
            {
                var reflection = new Reflection();
                reflection.RunActivity();
            }
            else if (choice == "3")
            {
                var listing = new Listing();
                listing.RunActivity();
            }
            else if (choice == "4")
            {
                break;
            }
        }
    }
}