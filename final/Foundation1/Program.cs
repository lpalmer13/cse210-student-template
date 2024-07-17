using System;
using System.Collections.Generic;

class Program
{ 
    static void Main(string[] args)
    {
        Video video1 = new Video("Video 1", "Author 1", 300);
        Video video2 = new Video("Video 2", "Author 2", 600);
        Video video3 = new Video("Video 3", "Author 3", 900);

        video1.AddComment(new Comment("User 1", "Great video!"));
        video1.AddComment(new Comment("User 2", "Very informative."));
        video1.AddComment(new Comment("User 3", "I loved it!"));
        video1.AddComment(new Comment("User 4", "Nice explanation."));
        video1.AddComment(new Comment("User 5", "Helped me a lot."));
        video1.AddComment(new Comment("User 6", "Well don!"));

        video2.AddComment(new Comment("User 7", "Nice work!"));
        video2.AddComment(new Comment("User 8", "Keep it up."));
        video2.AddComment(new Comment("User 9", "Awesome content."));
        video2.AddComment(new Comment("User 10", "Very helpful."));
        video2.AddComment(new Comment("User 11", "Learned a lot."));
        video2.AddComment(new Comment("User 12", "Good job!"));
        
        video3.AddComment(new Comment("User 13", "This is amazing!"));
        video3.AddComment(new Comment("User 14", "Fantastic explanation."));
        video3.AddComment(new Comment("User 15", "Really helpful."));
        video3.AddComment(new Comment("User 16", "Great content."));
        video3.AddComment(new Comment("User 17", "Very well presented."));
        video3.AddComment(new Comment("User 18", "Excellent video!"));


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