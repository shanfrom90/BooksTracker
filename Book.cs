using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalBookshelf
{
    public class Book
    {
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Comments { get; set; }
        public int Pages { get; set; }
        public bool HaveRead { get; set; }
        public bool IsFiction  { get; set; }
        public string Title { get; }

        public Book(string title, string author, string genre = "Unknown", bool haveRead, bool isFiction, int pages)
        {
            Title = title;
            Author = author;
            Genre = genre;
            HaveRead = haveRead;
            IsFiction = isFiction;
            Pages = pages;

        }
    }
}
