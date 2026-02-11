using MagicLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Library library = new Library { Name = "The Magic Library" };
        library.AddBook(new Book { Title = "The Great Gatsby", Pages = 180 });
        library.AddBook(new Book { Title = "To Kill a Mockingbird", Pages = 281 });
        library.AddBook(new Book { Title = "1984", Pages = 328 });

        Console.Write("Enter your name: ");
        string readerName = Console.ReadLine()?.Trim() ?? "Unknown";

        Reader reader = new Reader { Name = readerName, Energy = 100 };

        MenuSystem menu = new MenuSystem(library, reader);
        menu.Run();
    }
}