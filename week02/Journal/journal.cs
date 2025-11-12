// Journal.cs
using System;
using System.Collections.Generic;

public class Journal
{
    private List<JournalEntry> _entries;
    private string _journalName;
    
    public Journal(string journalName = "My Personal Journal")
    {
        _entries = new List<JournalEntry>();
        _journalName = journalName;
    }
    
    public string GetJournalName()
    {
        return _journalName;
    }
    
    public void SetJournalName(string newName)
    {
        _journalName = newName;
    }
    
    public void AddEntry(JournalEntry newEntry)
    {
        _entries.Add(newEntry);
    }
    
    public void DisplayAllEntries()
    {
        Console.WriteLine($"\n=== {_journalName} ===");
        Console.WriteLine($"Total Entries: {_entries.Count}\n");
        
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found. Start writing your first entry!");
            return;
        }
        
        foreach (JournalEntry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
    
    public List<JournalEntry> GetAllEntries()
    {
        return _entries;
    }
    
    public void ClearAllEntries()
    {
        _entries.Clear();
    }
}