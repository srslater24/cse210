using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while (true)
        {
            Menu menu = new Menu();
            menu.Display();
            Console.Write("Enter your response: ");
            string cmd = Console.ReadLine();
            if (cmd == "1")
            {
                // Get prompt
                PromptManager prompt_manager = new PromptManager();
                string currentPrompt = prompt_manager.GetPrompt();
                // Get response
                journal._currentPrompt = currentPrompt;
                string currentResponse = journal.Add_entry();
                // Turn into entry
                Entry entry = new Entry();
                entry._prompt = currentPrompt;
                entry._response = currentResponse;
                string fullEntry = entry.Display();
                // Store entry
                journal._entries.Add(fullEntry);
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