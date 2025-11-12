// FileHandler.cs
using System;
using System.Collections.Generic;
using System.IO;

public class FileHandler
{
    public void SaveJournalToFile(Journal journal, string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // Save journal metadata
                outputFile.WriteLine($"JOURNAL_NAME:{journal.GetJournalName()}");
                
                // Save all entries
                foreach (JournalEntry entry in journal.GetAllEntries())
                {
                    outputFile.WriteLine(entry.GetFormattedEntry());
                }
            }
            Console.WriteLine($"Journal successfully saved to: {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }
    
    public Journal LoadJournalFromFile(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine($" File not found: {filename}");
                return null;
            }
            
            string[] lines = File.ReadAllLines(filename);
            Journal loadedJournal = new Journal();
            
            foreach (string line in lines)
            {
                if (line.StartsWith("JOURNAL_NAME:"))
                {
                    string journalName = line.Substring("JOURNAL_NAME:".Length);
                    loadedJournal.SetJournalName(journalName);
                }
                else if (!string.IsNullOrEmpty(line))
                {
                    string[] parts = line.Split('|');
                    if (parts.Length >= 3)
                    {
                        string mood = parts.Length > 3 ? parts[3] : "";
                        JournalEntry loadedEntry = new JournalEntry(
                            parts[0], // date
                            parts[1], // prompt
                            parts[2], // content
                            mood      // mood
                        );
                        loadedJournal.AddEntry(loadedEntry);
                    }
                }
            }
            
            Console.WriteLine($"Journal successfully loaded from: {filename}");
            return loadedJournal;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
            return null;
        }
    }
    
    public List<string> GetSavedJournalFiles(string directory = ".")
    {
        List<string> journalFiles = new List<string>();
        try
        {
            string[] files = Directory.GetFiles(directory, "*.journal");
            journalFiles.AddRange(files);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading directory: {ex.Message}");
        }
        return journalFiles;
    }
}