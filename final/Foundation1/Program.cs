using System;
using System.Collections.Generic;

public class Program
{ 
    static void Main(string[] args)
    {
        Video video1 = new Video("Epic Fart Prank on Strangers", "GilstrapTV", 600);
        Video video2 = new Video("Farting in Elevator Prank", "GilstrapTV", 480);
        Video video3 = new Video("Office Fart Prank Compilation", "GilstrapTV", 900);
        Video video4 = new Video("Fart Prank at the Dinner Table", "GilstrapTV", 720);
        Video video5 = new Video("Surprise Fart Prank on Friends", "GilstrapTV", 540);
        Video video6 = new Video("Farting in Public Places Prank", "GilstrapTV", 660);

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

        video4.AddComment(new Comment("FamilyFun", "Hilarious prank! I showed it to my whole family."));
        video4.AddComment(new Comment("DinnerLaughter", "Couldn’t stop laughing at the reactions."));
        video4.AddComment(new Comment("TablePrankster", "Great prank idea. Definitely trying this."));
        video4.AddComment(new Comment("FoodieFarter", "The dinner table reactions are priceless."));
        video4.AddComment(new Comment("MealMischief", "Such a fun prank to pull at home."));
        video4.AddComment(new Comment("DinnerJokes", "Made dinner so much more entertaining. Thanks!"));

        video5.AddComment(new Comment("FriendFarter", "Totally caught my friends off guard."));
        video5.AddComment(new Comment("SurprisePranks", "They never saw it coming. Awesome!"));
        video5.AddComment(new Comment("PrankMaster", "Another great prank from GilstrapTV."));
        video5.AddComment(new Comment("LaughingCrew", "My friends are still talking about this one."));
        video5.AddComment(new Comment("SneakyPrankster", "Excellent prank execution. Well done!"));
        video5.AddComment(new Comment("SurpriseGenius", "Loved the surprise element. Hilarious!"));

        video6.AddComment(new Comment("PublicPranks", "Farting in public places is next level. So funny!"));
        video6.AddComment(new Comment("BravePranker", "Props to you for pulling this off in public."));
        video6.AddComment(new Comment("PublicHumor", "Loved the reactions from random people."));
        video6.AddComment(new Comment("LaughingCrowd", "This is epic. Can’t wait to see more like this."));
        video6.AddComment(new Comment("SocialPranks", "Best public prank video ever."));
        video6.AddComment(new Comment("GilstrapFanatic", "Your pranks always crack me up!"));

        List<Video> videos = new List<Video> { video1, video2, video3, video4, video5, video6 };
    
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