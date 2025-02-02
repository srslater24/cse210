using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Menu menu = new Menu();
        PromptManager prompt_manager = new PromptManager();
        while (true)
        {
            menu.Display();
            Console.Write("Enter your response: ");
            string cmd = Console.ReadLine();
            if (cmd == "1")
            {
                journal.Add_entry();
            }
            else if (cmd == "2")
            {
                journal.Display_entries();
            }
            else if (cmd == "3")
            {
                journal.SaveToFile();
            }
        }
    }
}