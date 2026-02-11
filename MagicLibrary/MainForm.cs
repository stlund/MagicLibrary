namespace MagicLibrary;

/// <summary>
/// Main application form for managing the magic library.
/// </summary>
internal partial class MainForm : Form
{
    private readonly Library _library;
    private readonly Reader _reader;
    private readonly List<Book> _borrowedBooks = [];

    public MainForm()
    {
        InitializeComponent();

        _library = new Library { Name = "The Magic Library" };
        _library.AddBook(new Book { Title = "The Great Gatsby", Pages = 180 });
        _library.AddBook(new Book { Title = "To Kill a Mockingbird", Pages = 281 });
        _library.AddBook(new Book { Title = "1984", Pages = 328 });

        _reader = new Reader { Name = "Alice", Energy = 100 };

        _txtReaderName.Text = _reader.Name;
        _txtReaderName.TextChanged += TxtReaderName_TextChanged;

        RefreshBookList();
        RefreshReaderStats();
        Log("Welcome to the Magic Library!");
    }

    private void BtnAddBook_Click(object? sender, EventArgs e)
    {
        string title = _txtTitle.Text.Trim();
        if (string.IsNullOrWhiteSpace(title))
        {
            MessageBox.Show("Please enter a book title.", "Missing Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int pages = (int)_nudPages.Value;
        Book book = new Book { Title = title, Pages = pages };
        _library.AddBook(book);

        _txtTitle.Clear();
        _nudPages.Value = 100;

        RefreshBookList();
        Log($"Added '{title}' ({pages} pages) to the library.");
    }

    private void BtnBorrow_Click(object? sender, EventArgs e)
    {
        Book? book = GetSelectedBook();
        if (book is null)
        {
            return;
        }

        _library.RemoveBook(book);
        _borrowedBooks.Add(book);

        RefreshBookList();
        Log($"{_reader.Name} borrowed '{book.Title}'.");
    }

    private void BtnReturn_Click(object? sender, EventArgs e)
    {
        if (_borrowedBooks.Count == 0)
        {
            MessageBox.Show("You have no borrowed books to return.", "Nothing to Return", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        // Let the user pick which borrowed book to return
        string[] titles = _borrowedBooks.Select(b => b.Title).ToArray();
        using SelectBookDialog dialog = new("Select a book to return:", titles);

        if (dialog.ShowDialog(this) != DialogResult.OK || dialog.SelectedTitle is null)
        {
            return;
        }

        Book? book = _borrowedBooks.FirstOrDefault(b =>
            b.Title.Equals(dialog.SelectedTitle, StringComparison.OrdinalIgnoreCase));

        if (book is null)
        {
            return;
        }

        _borrowedBooks.Remove(book);
        _reader.ReturnBook(_library, book);

        RefreshBookList();
        Log($"{_reader.Name} returned '{book.Title}'.");
    }

    private void BtnRead_Click(object? sender, EventArgs e)
    {
        Book? book = GetSelectedBook();
        if (book is null)
        {
            return;
        }

        int requiredEnergy = book.Pages / 2;
        if (_reader.Energy < requiredEnergy)
        {
            Log($"{_reader.Name} does not have enough energy to read '{book.Title}' (needs {requiredEnergy}, has {_reader.Energy}).");
            return;
        }

        int usedEnergy = _reader.ReadBook(book);
        RefreshReaderStats();
        Log($"{_reader.Name} read '{book.Title}' and used {usedEnergy} energy. Energy left: {_reader.Energy}.");
    }

    private void BtnRest_Click(object? sender, EventArgs e)
    {
        int hours = (int)_nudRestHours.Value;
        _reader.Rest(hours);
        RefreshReaderStats();
        Log($"{_reader.Name} rested for {hours} hour(s) and regained {hours * 10} energy. Energy: {_reader.Energy}.");
    }

    private void TxtReaderName_TextChanged(object? sender, EventArgs e)
    {
        string name = _txtReaderName.Text.Trim();
        if (!string.IsNullOrWhiteSpace(name))
        {
            _reader.Name = name;
        }
    }

    private Book? GetSelectedBook()
    {
        if (_lvBooks.SelectedItems.Count == 0)
        {
            MessageBox.Show("Please select a book from the list.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return null;
        }

        string title = _lvBooks.SelectedItems[0].Text;
        return _library.FindBookByTitle(title);
    }

    private void RefreshBookList()
    {
        _lvBooks.Items.Clear();
        foreach (Book book in _library.Books)
        {
            ListViewItem item = new ListViewItem(book.Title);
            item.SubItems.Add(book.Pages.ToString());
            _lvBooks.Items.Add(item);
        }

        _colTitle.Width = -1;
        _colPages.Width = -2;
    }

    private void RefreshReaderStats()
    {
        _lblEnergyValue.Text = _reader.Energy.ToString();
        _lblBooksReadValue.Text = LibraryService.totalBookRead.ToString();
    }

    private void Log(string message)
    {
        _txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}{Environment.NewLine}");
    }
}
