using System;
using System.Collections.Generic;

namespace AbstractionWithYouTubeVideos
{
    class Video
    {
        // fields
        private string title;
        private string author;
        private int lengthInSeconds;
        private List<Comment> comments;

        // constructor
        public Video(string title, string author, int lengthInSeconds)
        {
            this.title = title;
            this.author = author;
            this.lengthInSeconds = lengthInSeconds;
            comments = new List<Comment>();
        }

        // properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int LengthInSeconds
        {
            get { return lengthInSeconds; }
            set { lengthInSeconds = value; }
        }

        // methods
        public int GetNumberOfComments()
        {
            return comments.Count;
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Title: {0}", title);
            Console.WriteLine("Author: {0}", author);
            Console.WriteLine("Length (in seconds): {0}", lengthInSeconds);
            Console.WriteLine("Number of comments: {0}", GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in comments)
            {
                Console.WriteLine("- {0}: {1}", comment.Name, comment.Text);
            }
            Console.WriteLine();
        }
    }
}