using System;

public class Journal
{
    PromptManager promptManager = new PromptManager();
    public List<Entry> _entries = new List<Entry> {};
    public string _file_name;
    public void Add_entry()
    {
        Entry entry = new Entry();
        _entries.Add(entry);
        entry._prompt = promptManager.GetPrompt();
        Console.WriteLine(entry._prompt);
        entry._response = Console.ReadLine();
    }
    public void Display_entries()
    {
        Console.WriteLine("\nJournal Entries:");
        foreach (var entry in _entries)
        {
            Console.WriteLine("Date: 2025-1-30");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Response: {entry._response}");
        }
    }
    public void SaveToFile()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine("=====ENTRY=====");
                writer.WriteLine("Date: 2025-1-30");
                writer.WriteLine($"PROMPT: {entry._prompt}");
                writer.WriteLine($"RESPONSE: {entry._response}");
                writer.WriteLine("================");
            }
        }
        Console.WriteLine("Journal saved successfully!\n");
    }
}