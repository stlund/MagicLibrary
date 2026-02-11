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
    }
}
