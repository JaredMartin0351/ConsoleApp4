using System;

namespace ConsoleApp4
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        // Multiple constructors can be created

        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}