using System;
using System.Collections.Generic;
using System.Text;

namespace MagicLibrary
{
    internal class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public string Name { get; set; } = "Unnamed Library";

        // Method to add a book to the library
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        // Method to remove a book from the library
        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }
        //Method to show all books in the library
        public void ShowAllBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
        }
        //Method Find a book by title
        public Book FindBookByTitle(string title)
        {
            foreach (var book in Books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return book;
                }
            }
            return null;
        }
    }
}
