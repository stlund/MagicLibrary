using MagicLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Book b1 = new Book {Title = "The Great Gatsby", Pages = 180 };
        Book b2 = new Book {Title = "To Kill a Mockingbird", Pages = 281 };

        Reader r1 = new Reader { Name = "Alice", Energy = 100 };
        Reader r2 = new Reader { Name = "Bob", Energy = 20 };

        int usedEnergy = r1.ReadBook(b1);

        Console.WriteLine($"{r1.Name} använde {usedEnergy} energi. Energy kvar: {r1.Energy}");

        usedEnergy = r2.ReadBook(b2);
        Console.WriteLine($"{r2.Name} använde {usedEnergy} energi. Energy kvar: {r2.Energy}");

        // Visa totala antal lästa böcker
        Console.WriteLine($"Totalt lästa böcker: {LibraryService.totalBookRead}");
        Console.WriteLine();
    }
}