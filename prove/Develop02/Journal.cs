using System;

public class Journal
{
    public List<string> _entries = new List<string> {};
    public string _currentPrompt;
    public string _file_name;
    public string Add_entry()
    {
        Console.WriteLine($"Prompt: {_currentPrompt}");
        Console.Write("Enter your response: ");
        string response = Console.ReadLine();
        return response;
    }
    public void Display_entries()
    {
        Console.WriteLine("\nJournal Entries:");
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
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
                writer.WriteLine(entry);
            }
        }
        Console.WriteLine("Journal saved successfully!\n");
    }
}