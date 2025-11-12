// PromptManager.cs
using System;
using System.Collections.Generic;

public class PromptManager
{
    private List<string> _writingPrompts;
    private Random _randomGenerator;
    
    public PromptManager()
    {
        _randomGenerator = new Random();
        _writingPrompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What made me smile today?",
            "What lesson did I learn today?",
            "What am I grateful for today?",
            "What challenge did I overcome today?",
            "What would I like to remember about today?"
        };
    }
    
    public string GetRandomPrompt()
    {
        int index = _randomGenerator.Next(_writingPrompts.Count);
        return _writingPrompts[index];
    }
    
    public void AddCustomPrompt(string newPrompt)
    {
        _writingPrompts.Add(newPrompt);
    }
    
    public void DisplayAllPrompts()
    {
        Console.WriteLine("\nAvailable Writing Prompts:");
        for (int i = 0; i < _writingPrompts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_writingPrompts[i]}");
        }
    }
    
    public int GetPromptCount()
    {
        return _writingPrompts.Count;
    }
}