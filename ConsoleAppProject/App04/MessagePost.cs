using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{

    public class MessagePost : Post
    {
        /// <summary>
        /// Variable declared for use in app
        /// </summary>
        public String Message;

        /// <summary>
        /// Where you create where the text will go
        /// </summary>
        public MessagePost(String text, string author) : base(author)
        {
            Message = text;
        }

        /// <summary>
        /// For Displaying Message Post
        /// </summary>
        public override void Display()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("      Message Post");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine($"      " +
                $"Messsage: {Message}");

            base.Display();
        }

    }
}
