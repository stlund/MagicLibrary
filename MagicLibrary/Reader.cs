using System;
using System.Collections.Generic;
using System.Text;

namespace MagicLibrary
{
    internal class Reader
    {
        public string Name { get; set; } = "Unknown Reader";
        public int Energy { get; set; } = 200;

        public int ReadBook(Book book)
        {
            // Condition to check if the reader has enough energy to read the book
            int requiredEnergy = book.Pages / 2;
            if (Energy < requiredEnergy)
            {
                Console.WriteLine($"{Name} has not enough energy to read the book {book.Title}");
                return 0;
            }

            else
            {
                Console.WriteLine($"{Name} has enough energy to read the book {book.Title}");
                int usedEnergy = book.Pages / 2;
                Energy -= usedEnergy;
                LibraryService.LogRead();
                return usedEnergy;
            }
        }
        // Method to borrow a book from the library
        public Book BorrowBook(Library library, string title)
        {
            Book book = library.FindBookByTitle(title);
            if (book != null)
            {
                library.RemoveBook(book);
                Console.WriteLine($"{Name} borrowed the book {book.Title}");
                return book;
            }
            else
            {
                Console.WriteLine($"The book {title} is not available in the library.");
                return null;
            }
        }
        //Method to return a book to the library
        public void ReturnBook(Library library, Book book)
        {
            library.AddBook(book);
            Console.WriteLine($"{Name} returned the book {book.Title}");
        }
        // Method to rest and regain energy
        public void Rest(int hours)
        {
            Energy += hours * 10;
            Console.WriteLine($"{Name} rested for {hours} hours and regained {hours * 10} energy.");
        }
    }
}