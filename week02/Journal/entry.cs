// JournalEntry.cs
using System;

public class JournalEntry
{
    public string EntryDate { get; set; }
    public string PromptText { get; set; }
    public string EntryContent { get; set; }
    public string EntryMood { get; set; }
    
    public JournalEntry(string date, string prompt, string content, string mood = "")
    {
        EntryDate = date;
        PromptText = prompt;
        EntryContent = content;
        EntryMood = mood;
    }
    
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {EntryDate}");
        Console.WriteLine($"Prompt: {PromptText}");
        if (!string.IsNullOrEmpty(EntryMood))
        {
            Console.WriteLine($"Mood: {EntryMood}");
        }
        Console.WriteLine($"Entry: {EntryContent}");
        Console.WriteLine("─".PadRight(50, '─') + "\n");
    }
    
    public string GetFormattedEntry()
    {
        return $"{EntryDate}|{PromptText}|{EntryContent}|{EntryMood}";
    }
}