namespace MagicLibrary;

/// <summary>
/// Interactive console menu for the magic library application.
/// </summary>
internal class MenuSystem
{
    private readonly Library _library;
    private readonly Reader _reader;

    public MenuSystem(Library library, Reader reader)
    {
        _library = library;
        _reader = reader;
    }

    /// <summary>
    /// Starts the main menu loop. Runs until the user chooses to exit.
    /// </summary>
    public void Run()
    {
        bool running = true;

        while (running)
        {
            PrintMenu();
            string choice = Console.ReadLine()?.Trim() ?? string.Empty;

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    ShowAllBooks();
                    break;
                case "3":
                    BorrowBook();
                    break;
                case "4":
                    ReturnBook();
                    break;
                case "5":
                    ReadBook();
                    break;
                case "6":
                    Rest();
                    break;
                case "7":
                    ShowStats();
                    break;
                case "0":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    private static void PrintMenu()
    {
        Console.WriteLine("========== Magic Library ==========");
        Console.WriteLine("1. Add a book to the library");
        Console.WriteLine("2. Show all books");
        Console.WriteLine("3. Borrow a book");
        Console.WriteLine("4. Return a book");
        Console.WriteLine("5. Read a book");
        Console.WriteLine("6. Rest and regain energy");
        Console.WriteLine("7. Show stats");
        Console.WriteLine("0. Exit");
        Console.Write("Choose an option: ");
    }

    private void AddBook()
    {
        Console.Write("Enter book title: ");
        string title = Console.ReadLine()?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(title))
        {
            Console.WriteLine("Title cannot be empty.");
            return;
        }

        Console.Write("Enter number of pages: ");
        if (!int.TryParse(Console.ReadLine(), out int pages) || pages <= 0)
        {
            Console.WriteLine("Invalid number of pages.");
            return;
        }

        Book book = new Book { Title = title, Pages = pages };
        _library.AddBook(book);
        Console.WriteLine($"'{title}' ({pages} pages) added to the library.");
    }

    private void ShowAllBooks()
    {
        if (_library.Books.Count == 0)
        {
            Console.WriteLine("The library has no books.");
            return;
        }

        Console.WriteLine($"--- Books in {_library.Name} ---");
        for (int i = 0; i < _library.Books.Count; i++)
        {
            Book book = _library.Books[i];
            Console.WriteLine($"  {i + 1}. {book.Title} ({book.Pages} pages)");
        }
    }

    private void BorrowBook()
    {
        Console.Write("Enter the title of the book to borrow: ");
        string title = Console.ReadLine()?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(title))
        {
            Console.WriteLine("Title cannot be empty.");
            return;
        }

        _reader.BorrowBook(_library, title);
    }

    private void ReturnBook()
    {
        Console.Write("Enter the title of the book to return: ");
        string title = Console.ReadLine()?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(title))
        {
            Console.WriteLine("Title cannot be empty.");
            return;
        }

        // Create a book instance with the given title so it can be added back
        Console.Write("Enter number of pages: ");
        if (!int.TryParse(Console.ReadLine(), out int pages) || pages <= 0)
        {
            Console.WriteLine("Invalid number of pages.");
            return;
        }

        Book book = new Book { Title = title, Pages = pages };
        _reader.ReturnBook(_library, book);
    }

    private void ReadBook()
    {
        Console.Write("Enter the title of the book to read: ");
        string title = Console.ReadLine()?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(title))
        {
            Console.WriteLine("Title cannot be empty.");
            return;
        }

        Book book = _library.FindBookByTitle(title);
        if (book is null)
        {
            Console.WriteLine($"The book '{title}' was not found in the library.");
            return;
        }

        int usedEnergy = _reader.ReadBook(book);
        if (usedEnergy > 0)
        {
            Console.WriteLine($"{_reader.Name} used {usedEnergy} energy. Energy left: {_reader.Energy}");
        }
    }

    private void Rest()
    {
        Console.Write("Enter hours to rest: ");
        if (!int.TryParse(Console.ReadLine(), out int hours) || hours <= 0)
        {
            Console.WriteLine("Invalid number of hours.");
            return;
        }

        _reader.Rest(hours);
    }

    private void ShowStats()
    {
        Console.WriteLine($"--- Reader Stats ---");
        Console.WriteLine($"  Name:   {_reader.Name}");
        Console.WriteLine($"  Energy: {_reader.Energy}");
        Console.WriteLine($"  Total books read (all readers): {LibraryService.totalBookRead}");
        Console.WriteLine($"  Books in library: {_library.Books.Count}");
    }
}
