using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class Posts
    {
        public int PostId { get; }

        public string Username { get; }

        public DateTime Timestamp { get; }

        private static int instances = 0;

        private int likes;

        private readonly List<String> comments;

        public NewsFeed NewsFeed = new NewsFeed();

        /// <summary>
        /// 
        /// </summary>
        public Posts(string author)
        {
            instances++;
            PostId = instances;

            this.Username = author;
            this.Timestamp = DateTime.Now;

            likes = 0;
            comments = new List<String>();
        }

        public void Like()
        {
            likes++;
        }

        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }
    }
}
