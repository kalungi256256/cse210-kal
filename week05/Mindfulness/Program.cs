using System;
using System.Threading;

class Program
{
    // CREATIVITY: Added activity logging and unique prompt selection
    private static int _totalActivitiesCompleted = 0;
    private static Dictionary<string, int> _activityCounts = new Dictionary<string, int>
    {
        {"Breathing", 0},
        {"Reflecting", 0},
        {"Listing", 0}
    };

    static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness Program - Track Your Progress!");
        Console.WriteLine("Enhanced with activity logging and statistics! 🎯");
        
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    RunActivity(new BreathingActivity());
                    break;
                case "2":
                    RunActivity(new ReflectingActivity());
                    break;
                case "3":
                    RunActivity(new ListingActivity());
                    break;
                case "4":
                    DisplayStatistics();
                    break;
                case "5":
                    Console.WriteLine("Thank you for practicing mindfulness. Goodbye! 🌟");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    ShowSpinner(2);
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Mindfulness Program");
        Console.WriteLine($"Total Activities Completed: {_totalActivitiesCompleted}");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. View statistics");
        Console.WriteLine("  5. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    static void RunActivity(Activity activity)
    {
        activity.RunActivity();
        _totalActivitiesCompleted++;
        _activityCounts[activity.GetType().Name.Replace("Activity", "")]++;
        
        Console.WriteLine();
        Console.WriteLine("Activity completed! Press enter to continue...");
        Console.ReadLine();
    }

    static void DisplayStatistics()
    {
        Console.Clear();
        Console.WriteLine("=== Mindfulness Statistics ===");
        Console.WriteLine($"Total sessions: {_totalActivitiesCompleted}");
        Console.WriteLine($"Breathing activities: {_activityCounts["Breathing"]}");
        Console.WriteLine($"Reflecting activities: {_activityCounts["Reflecting"]}");
        Console.WriteLine($"Listing activities: {_activityCounts["Listing"]}");
        Console.WriteLine();
        Console.WriteLine("Press enter to continue...");
        Console.ReadLine();
    }

    static void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        
        while (DateTime.Now < endTime)
        {
            foreach (string frame in spinner)
            {
                Console.Write(frame);
                Thread.Sleep(250);
                Console.Write("\b \b");
                if (DateTime.Now >= endTime) break;
            }
        }
    }
}