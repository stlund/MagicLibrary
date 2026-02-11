namespace MagicLibrary;

/// <summary>
/// Simple dialog that lets the user select a book title from a list.
/// </summary>
internal partial class SelectBookDialog : Form
{
    public string? SelectedTitle { get; private set; }

    public SelectBookDialog(string prompt, string[] titles)
    {
        InitializeComponent();
        _lblPrompt.Text = prompt;
        _lstBooks.Items.AddRange(titles);

        if (_lstBooks.Items.Count > 0)
        {
            _lstBooks.SelectedIndex = 0;
        }
    }

    private void BtnOk_Click(object? sender, EventArgs e)
    {
        if (_lstBooks.SelectedItem is string selected)
        {
            SelectedTitle = selected;
            DialogResult = DialogResult.OK;
        }
    }

    private void BtnCancel_Click(object? sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
    }
}
