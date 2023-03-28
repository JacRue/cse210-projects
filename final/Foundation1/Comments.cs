using System;

namespace AbstractionWithYouTubeVideos
{
    class Comment
    {
        // fields
        private string name;
        private string text;

        // constructor
        public Comment(string name, string text)
        {
            this.name = name;
            this.text = text;
        }

        // proerties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}