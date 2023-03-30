using System;
using System.Collections.Generic;
using System.Transactions;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Michael Kölling and David J. Barnes
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        private readonly List<MessagePost> messages;
        private readonly List<PhotoPost> photos;

        public List<MessagePost> Filename { get; private set; }
        public string Author { get; private set; }
        public List<MessagePost> Caption { get; private set; }

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            messages = new List<MessagePost>();
            photos = new List<PhotoPost>();
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            messages.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            photos.Add(photo);
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (MessagePost message in messages)
            {
                message.Display();
                Console.WriteLine();   // empty line between posts
            }

            // display all photos
            foreach (PhotoPost photo in photos)
            {
                photo.Display();
                Console.WriteLine();   // empty line between posts
            }
        }

        internal void AddComment(int iD, string comment)
        {
            throw new NotImplementedException();
        }

        internal double AmountOfPosts()
        {
            throw new NotImplementedException();
        }

        public List<MessagePost> GetMessages()
        {
            return messages;
        }

        public void CreateMessagePost(List<MessagePost> GetMessages)
        {
            Console.WriteLine();
            GetMessages = EnterText("Please Enter Message");
        }

        private List<MessagePost> EnterText(string Message)
        {
            string text;
            Console.Write(Message);
            text = Console.ReadLine();
            return text;
        }

        public void CreatePhotoPost()
        {
            Console.WriteLine();
            Filename = EnterText("Enter Filename >");
            Console.WriteLine();
            Caption = EnterText("Enter Caption >");
            Console.WriteLine();
            PhotoPost message = new PhotoPost(Author, Filename, Caption);
            AddPhotoMessage(message);
        }

        private void AddPhotoMessage(PhotoPost message)
        {
            throw new NotImplementedException();
        }

        public void FindMessages(int ID)
        {
            foreach (MessagePost message in messages)
                if (message.MessageId == ID)
                {
                    return;
                }
        }

        public void FindPostByAuthor(string author)
        {
            foreach (MessagePost message in messages)
                if (message.Author == author)
                {
                    message.Display();
                }
                else
                {
                    Console.WriteLine("Author Not Found");
                }
        }

        internal void LikePost(int ID)
        {
            foreach (MessagePost message in messages)

                if (message.PostID == ID)
                {
                    message.Like();
                }
        }

        public void RemovePost(int ID)
        {
            MessagePost message = FindMessages(ID);

            if (message != null)
            {
                Console.WriteLine($"\n The Post with ID {ID} has been Removed");
                message.Remove(message);
            }
            else
            {
                Console.WriteLine($"\n The Post with ID {ID} does not exist");

                messages.Remove(message);
                message.Display();
            }
        }

        internal void UnlikePost(int ID)
        {
            foreach (MessagePost message in messages)

                if (message.PostID == ID)
                {
                    message.Unlike();
                }
        }
    }

}
