// JournalProgram.cs
using System;
using System.Collections.Generic;

public class JournalProgram
{
    private Journal _currentJournal;
    private PromptManager _promptManager;
    private FileHandler _fileHandler;
    
    public JournalProgram()
    {
        _promptManager = new PromptManager();
        _fileHandler = new FileHandler();
        _currentJournal = new Journal();
    }
    
    public void Run()
    {
        Console.WriteLine(" Welcome to the Personal Journal Program!");
        Console.WriteLine(" Your digital space for reflection and growth\n");
        
        bool isRunning = true;
        
        while (isRunning)
        {
            DisplayMainMenu();
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    ShowProgramInfo();
                    break;
                case "6":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine(" Invalid choice. Please select 1-6.");
                    break;
            }
            
            if (isRunning)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        
        Console.WriteLine("\nThank you for using the Personal Journal Program! 📖");
        Console.WriteLine("Keep writing and reflecting!");
    }
    
    private void DisplayMainMenu()
    {
        Console.WriteLine("JOURNAL MAIN MENU ");
        Console.WriteLine("1.Write New Entry");
        Console.WriteLine("2.Display Journal");
        Console.WriteLine("3.Save Journal");
        Console.WriteLine("4.Load Journal");
        Console.WriteLine("5.Program Info");
        Console.WriteLine("6.Exit");
        Console.Write("Select an option (1-6): ");
    }
    
    private void WriteNewEntry()
    {
        Console.WriteLine("\n Writing New Journal Entry");
        Console.WriteLine("─────────────────────────────");
        
        string prompt = _promptManager.GetRandomPrompt();
        Console.WriteLine($"💭 Your Prompt: {prompt}");
        
        Console.Write("Write your entry: ");
        string response = Console.ReadLine();
        
        Console.Write("How are you feeling today? (optional): ");
        string mood = Console.ReadLine();
        
        string currentDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
        
        JournalEntry newEntry = new JournalEntry(currentDate, prompt, response, mood);
        _currentJournal.AddEntry(newEntry);
        
        Console.WriteLine("Entry saved successfully!");
    }
    
    private void DisplayJournal()
    {
        _currentJournal.DisplayAllEntries();
    }
    
    private void SaveJournal()
    {
        Console.Write(" Enter filename to save (e.g., myjournal.journal): ");
        string filename = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(filename))
        {
            filename = $"{_currentJournal.GetJournalName().Replace(" ", "_")}.journal";
        }
        
        _fileHandler.SaveJournalToFile(_currentJournal, filename);
    }
    
    private void LoadJournal()
    {
        Console.WriteLine("\nAvailable Journal Files:");
        List<string> journalFiles = _fileHandler.GetSavedJournalFiles();
        
        if (journalFiles.Count == 0)
        {
            Console.WriteLine("No journal files found in current directory.");
            return;
        }
        
        for (int i = 0; i < journalFiles.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {journalFiles[i]}");
        }
        
        Console.Write("Enter the filename to load: ");
        string filename = Console.ReadLine();
        
        Journal loadedJournal = _fileHandler.LoadJournalFromFile(filename);
        if (loadedJournal != null)
        {
            _currentJournal = loadedJournal;
            Console.WriteLine($"✅ Loaded journal: {_currentJournal.GetJournalName()}");
        }
    }
    
    private void ShowProgramInfo()
    {
        Console.WriteLine("\nPersonal Journal Program Information");
        Console.WriteLine("───────────────────────────────────────");
        Console.WriteLine($"Total Writing Prompts: {_promptManager.GetPromptCount()}");
        Console.WriteLine($"Current Journal: {_currentJournal.GetJournalName()}");
        Console.WriteLine($"Entries in Journal: {_currentJournal.GetAllEntries().Count}");
        Console.WriteLine("\nFeatures:");
        Console.WriteLine("Daily writing prompts");
        Console.WriteLine("  • Mood tracking");
        Console.WriteLine("  • File saving/loading");
        Console.WriteLine("  • Beautiful display formatting");
    }
}
