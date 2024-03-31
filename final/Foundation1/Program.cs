using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Title 1", "Author 1", 120);
        video1.AddComment("User1", "Comment 1");
        video1.AddComment("User2", "Comment 2");
        videos.Add(video1);

        Video video2 = new Video("Title 2", "Author 2", 180);
        video2.AddComment("User3", "Comment 3");
        videos.Add(video2);

        foreach (var video in videos) {
            video.DisplayDetails();
        }
    }
}
