using System;

// DOESNT WORK -- NEED TO STORE FILE SOMEWHERE VIABLE
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Shopping Cart Program\n");

        // nouns - variables
        List<string> names = new List<string>();
        List<double> prices = new List<double>();

        bool done = false;
        while (!done)
        {
            DisplayMenu();
            string choice = GetChoice();

            if (choice == "1")
            {
                Add(names, prices);
            } else if (choice == "2")
            {
                Remove();
            } else if (choice == "3")
            {
                Display(names, prices);
            } else if (choice == "4")
            {
                double total = CalcTotal(prices);
                Console.WriteLine($"Total = {total}");
            } else if (choice == "5")
            {
                done = true;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("1) Add");
        Console.WriteLine("2) Remove");
        Console.WriteLine("3) Display");
        Console.WriteLine("4) Total");
        Console.WriteLine("5) Quit\n");
    }

    static string GetChoice()
    {
        //assume: the menu is displayed
        Console.Write("Enter choice: ");
        string choice = Console.ReadLine();
        return choice;
    }

    static void Add(List<string> names, List<string> prices)
    {
        // assume: ask user, add to lists
        Console.Write("Enter name of item: ");
        string name = Console.ReadLine();

        Console.Write("Enter price of item: ");
        string priceString = Console.ReadLine();
        double price = Convert.ToDouble(priceString);

        name.Add(name);
        prices.Add(price);
    }

    static double CalcTotal(List<double> prices)
    {
        double total = 0;
        foreach (ver price in prices)
        {
            total += price;
        }

        return total;
    }

    static void Remove()
    {

    }

    static void Display(List<string> names, List<string> prices)
    {
        Console.WriteLine("Cart");
        Console.WriteLine("================================");

        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine($"{names[i],15}: {prices[i]}");
        }

        Console.WriteLine("================================");
    }
}