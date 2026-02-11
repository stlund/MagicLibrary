namespace MagicLibrary;

partial class SelectBookDialog
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        _tlpMain = new TableLayoutPanel();
        _lblPrompt = new Label();
        _lstBooks = new ListBox();
        _flpButtons = new FlowLayoutPanel();
        _btnCancel = new Button();
        _btnOk = new Button();

        _tlpMain.SuspendLayout();
        _flpButtons.SuspendLayout();
        SuspendLayout();

        // _tlpMain
        _tlpMain.ColumnCount = 1;
        _tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        _tlpMain.RowCount = 3;
        _tlpMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        _tlpMain.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _tlpMain.Controls.Add(_lblPrompt, 0, 0);
        _tlpMain.Controls.Add(_lstBooks, 0, 1);
        _tlpMain.Controls.Add(_flpButtons, 0, 2);
        _tlpMain.Dock = DockStyle.Fill;
        _tlpMain.Padding = new Padding(8);
        _tlpMain.Name = "_tlpMain";

        // _lblPrompt
        _lblPrompt.AutoSize = true;
        _lblPrompt.Dock = DockStyle.Fill;
        _lblPrompt.Name = "_lblPrompt";
        _lblPrompt.Text = "Select a book:";
        _lblPrompt.Margin = new Padding(3, 3, 3, 6);

        // _lstBooks
        _lstBooks.Dock = DockStyle.Fill;
        _lstBooks.Name = "_lstBooks";
        _lstBooks.Margin = new Padding(3);

        // _flpButtons
        _flpButtons.AutoSize = true;
        _flpButtons.Dock = DockStyle.Fill;
        _flpButtons.FlowDirection = FlowDirection.RightToLeft;
        _flpButtons.Controls.Add(_btnCancel);
        _flpButtons.Controls.Add(_btnOk);
        _flpButtons.Name = "_flpButtons";
        _flpButtons.Margin = new Padding(0, 6, 0, 0);

        // _btnCancel
        _btnCancel.Name = "_btnCancel";
        _btnCancel.Size = new Size(80, 30);
        _btnCancel.Text = "Cancel";
        _btnCancel.DialogResult = DialogResult.Cancel;
        _btnCancel.Click += BtnCancel_Click;

        // _btnOk
        _btnOk.Name = "_btnOk";
        _btnOk.Size = new Size(80, 30);
        _btnOk.Text = "OK";
        _btnOk.Click += BtnOk_Click;

        // SelectBookDialog
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(320, 260);
        MinimumSize = new Size(280, 200);
        Controls.Add(_tlpMain);
        AcceptButton = _btnOk;
        CancelButton = _btnCancel;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        StartPosition = FormStartPosition.CenterParent;
        Name = "SelectBookDialog";
        Text = "Select Book";

        _tlpMain.ResumeLayout(false);
        _tlpMain.PerformLayout();
        _flpButtons.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel _tlpMain;
    private Label _lblPrompt;
    private ListBox _lstBooks;
    private FlowLayoutPanel _flpButtons;
    private Button _btnOk;
    private Button _btnCancel;
}
