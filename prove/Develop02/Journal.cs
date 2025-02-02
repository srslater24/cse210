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
        string filename = "journal.txt";
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"Date: 2025-1-30|Prompt: {entry._prompt}|Response: {entry._response}");
            }
        }
        Console.WriteLine("Journal saved successfully!\n");
    }
    public void Load()
    {
        string filename = "journal.txt";
        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry entry = new Entry();
            entry._prompt = parts[1];
            entry._response = parts[2];
            _entries.Add(entry);
        }
    }
}