using System;
using System.Collections.Generic;

namespace AbstractionWithYouTubeVideos
{



    class Program
    {
        static void Main(string[] args)
        {
            // create videos and comments
            Video video1 = new Video("Batman catches Joker", "thebatman123", 120);
            video1.AddComment(new Comment("comicman45", "This is amazing!"));
            video1.AddComment(new Comment("robin99", "I love this video!"));
            video1.AddComment(new Comment("joker101", "Joker is so much better than Batman!"));

            Video video2 = new Video("How to make pizza", "chefjohn", 300);
            video2.AddComment(new Comment("pizzalover7", "This looks delicious!"));
            video2.AddComment(new Comment("vegan4life", "I'll have to try this with vegan cheese!"));

            Video video3 = new Video("Guitar cover of 'Stairway to Heaven", "guitarhero123", 420);
            video3.AddComment(new Comment("musiclover999", "This is one of my favorite songs!"));
            video3.AddComment(new Comment("guitarplayer123", "You're really talented!"));

            // add videos to list
            List<Video> videos = new List<Video>();
            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            // display information for each video
            foreach (Video video in videos)
            {
                video.DisplayInformation();
            }
            Console.ReadLine(); // wait for user input before closing console

        }
    }
}