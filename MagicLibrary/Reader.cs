using System;
using System.Collections.Generic;
using System.Text;

namespace MagicLibrary
{
    internal class Reader
    {
        public string Name { get; set; }
        public int Energy { get; set; } = 100;

        public void ReadBook(Book book)
        {
            Energy -= book.Pages / (book.Pages / 2);
        }
    }
}
