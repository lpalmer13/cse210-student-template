using System;
using System.Collections.Generic;

class Program
{ 
    static void Main(string[] args)
    {
        Video video1 = new Video("Epic Fart Prank on Strangers", "GilstrapTV", 600);
        Video video2 = new Video("Farting in Elevator Prank", "GilstrapTV", 480);
        Video video3 = new Video("Office Fart Prank Compilation", "GilstrapTV", 900);

        video1.AddComment(new Comment("PrankLover", "I couldn't stop laughing! Epic prank!"));
        video1.AddComment(new Comment("LaughOutLoud", "This made my day. So funny!"));
        video1.AddComment(new Comment("ComedyKing", "GilstrapTV, you are the best at pranks."));
        video1.AddComment(new Comment("Giggles", "The reactions were priceless!"));
        video1.AddComment(new Comment("Jokester", "I'm crying from laughing so hard."));
        video1.AddComment(new Comment("FartFanatic", "That was too good. Keep it up!"));

        video2.AddComment(new Comment("ElevatorEscape", "Imagine being stuck in that elevator. Hilarious!"));
        video2.AddComment(new Comment("TrappedInLaughs", "The best elevator prank ever."));
        video2.AddComment(new Comment("FunnyBone", "I can't get enough of these pranks."));
        video2.AddComment(new Comment("Prankster", "GilstrapTV, you never disappoint."));
        video2.AddComment(new Comment("LMAO", "That was savage and funny."));
        video2.AddComment(new Comment("ElevatorPrankster", "Brilliant execution. Loved every second."));
        
        video3.AddComment(new Comment("OfficePrankster", "Best compilation of office pranks I've seen."));
        video3.AddComment(new Comment("DeskJester", "My coworkers would freak out if I did this."));
        video3.AddComment(new Comment("LaughingOutLoud", "This is why I love your channel."));
        video3.AddComment(new Comment("PrankCompilationFan", "Never laughed so hard. Amazing job!"));
        video3.AddComment(new Comment("OfficeHumor", "I needed this laugh today. Thanks!"));
        video3.AddComment(new Comment("GilstrapFan", "You are the king of pranks, GilstrapTV!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };
    
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.GetFormattedLength()}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"Comment by {comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}