using ConsoleAppProject.Helpers;
using LanguageExt;
using LanguageExt.Pretty;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        public NewsFeed NewsFeed = new NewsFeed();

        public void Run ()
        {
            DisplayMenu();
        }

        public void DisplayMenu ()
        {
            ConsoleHelper.OutputHeading("Uthmans News Feed");

            string[] choices = new string[]
            {
                "Add Message Post", "Add Photo Post",
                "Display All Post", "Display Post By Date",
                "LIke/Unlike Post", "Quit"
            };

            bool wantToQuit = false;

            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: NewsFeed.CreateMessagePost(NewsFeed.GetMessages()); break;
                    case 2: NewsFeed.CreatePhotoPost(); break;
                    case 3: DisplayAll(); break;
                    case 4: DisplayByAuthor(); break;
                    case 5: int ID; RemovePost(); break;
                    case 6: ID = LikePost(); break;
                    case 7: ID = UnlikePost(); break;
                    case 8: ID = AddComment(); break;
                    case 9: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        private void DisplayAll()
        {
            NewsFeed.Display();
        }

        private void DisplayByAuthor()
        {
            DisplayAll();
            Console.Write("Enter Author Name> ");
            string author = Console.ReadLine();
            NewsFeed.FindPostByAuthor(author);
            Console.WriteLine();
        }

        private void RemovePost()
        {
            DisplayAll();
            ConsoleHelper.OutputTitle($"Please Remove a Post");
            int ID = (int)ConsoleHelper.InputNumber("Please Enter The Post ID For The Post You Want To Remove> ", 1, NewsFeed.AmountOfPosts());
            NewsFeed.FindMessages(ID);
            NewsFeed.RemovePost(ID);
            Console.WriteLine();
        }

        private int LikePost()
        {
            int ID = (int)ConsoleHelper.InputNumber("Enter Post ID For The Post You Want To Like> ", 1, NewsFeed.AmountOfPosts());
            NewsFeed.LikePost(ID);
            return ID;
        }

        private int UnlikePost()
        {
            int ID = (int)ConsoleHelper.InputNumber("Enter Post ID For The Post You Want To Unlike> ", 1, NewsFeed.AmountOfPosts());
            NewsFeed.UnlikePost(ID);
            return ID;
        }

        private int AddComment()
        {
            int ID = (int)ConsoleHelper.InputNumber("Enter Post ID For The Post You Want To Comment> ", 1, NewsFeed.AmountOfPosts());
            Console.WriteLine();
            Console.WriteLine("Enter Your Comment");
            string comment = Console.ReadLine();
            NewsFeed.AddComment(ID, comment);
            return ID;
        }
    }
}
