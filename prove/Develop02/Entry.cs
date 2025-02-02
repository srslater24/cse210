using System;

public class Entry
{
    public string _prompt;
    public string _response;
    public string Display()
    {
        string date = "2025-1-30";
        string full_entry = $"Date: {date} / Prompt: {_prompt}\nResponse: {_response}";

        Console.WriteLine(full_entry);
        return full_entry;
    }
}