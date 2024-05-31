using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // YTV 1
        Video video1 = new Video("Nyancat", "Mr. T", 3600);
        video1.AddComment(new Comment("GreenPea", "Great video!"));
        video1.AddComment(new Comment("textmachine09", "I cant stop listening to this"));
        video1.AddComment(new Comment("Steepheen28", "I hate your channel blablablabla...."));
        videos.Add(video1);

        // YTV 2
        Video video2 = new Video("taking the hobbits to isengard", "Aaron Hardbarger", 129);
        video2.AddComment(new Comment("4thQuarterLetDown", "If this video is deleted, the internet dies..."));
        video2.AddComment(new Comment("Blarg6306", "CAlmost 14 years later and they're still taking the hobbits to Isengard."));
        video2.AddComment(new Comment("LilSunny1986", "Fun fact: They never took the Hobbits to Isengard."));
        videos.Add(video2);

        // YTV 3
        Video video3 = new Video("Never Gonna Give You Up", "Rick Astley", 212);
        video3.AddComment(new Comment("MemeDogOfficials", "wait, this wasn’t the link for free robux"));
        video3.AddComment(new Comment("cal3819", "When they put ads so you can't rickroll anymore"));
        video3.AddComment(new Comment("Freddyfazbea2", "Play this at my funeral"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}