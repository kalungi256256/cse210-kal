class Program
{
    static void Main(string[] args)
    {
        // Create videos
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Programming Tutorial", "CodeMaster", 600);
        video1.AddComment(new Comment("Alice", "Great tutorial! Very helpful for beginners."));
        video1.AddComment(new Comment("Bob", "I learned so much from this video."));
        video1.AddComment(new Comment("Charlie", "Could you make a video on inheritance?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("ASP.NET Core Web Development", "WebWizard", 1200);
        video2.AddComment(new Comment("Diana", "This changed how I build web apps!"));
        video2.AddComment(new Comment("Eve", "Perfect explanation of middleware."));
        video2.AddComment(new Comment("Frank", "When is the next part coming out?"));
        video2.AddComment(new Comment("Grace", "Loved the practical examples."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Entity Framework Crash Course", "DatabasePro", 900);
        video3.AddComment(new Comment("Henry", "Finally understand EF relationships!"));
        video3.AddComment(new Comment("Ivy", "The migration examples were super clear."));
        video3.AddComment(new Comment("Jack", "Would love to see more advanced topics."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("C# Design Patterns", "ArchitectExpert", 1500);
        video4.AddComment(new Comment("Karen", "Singleton pattern explanation was perfect."));
        video4.AddComment(new Comment("Leo", "This helped me ace my interview!"));
        video4.AddComment(new Comment("Mia", "Repository pattern example was exactly what I needed."));
        video4.AddComment(new Comment("Nathan", "Can you cover more behavioral patterns?"));
        videos.Add(video4);

        // Display all videos and their comments
        Console.WriteLine("YouTube Video Analysis Program");
        Console.WriteLine("==============================\n");

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}