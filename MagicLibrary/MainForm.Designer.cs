namespace MagicLibrary;

partial class MainForm
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
        _tlpLeft = new TableLayoutPanel();
        _grpLibrary = new GroupBox();
        _lvBooks = new ListView();
        _colTitle = new ColumnHeader();
        _colPages = new ColumnHeader();
        _grpAddBook = new GroupBox();
        _tlpAddBook = new TableLayoutPanel();
        _lblTitle = new Label();
        _txtTitle = new TextBox();
        _lblPages = new Label();
        _nudPages = new NumericUpDown();
        _btnAddBook = new Button();
        _tlpRight = new TableLayoutPanel();
        _grpReader = new GroupBox();
        _tlpReader = new TableLayoutPanel();
        _lblReaderName = new Label();
        _cboReader = new ComboBox();
        _lblNewReader = new Label();
        _txtNewReaderName = new TextBox();
        _btnAddReader = new Button();
        _lblEnergy = new Label();
        _lblEnergyValue = new Label();
        _lblBooksRead = new Label();
        _lblBooksReadValue = new Label();
        _grpActions = new GroupBox();
        _tlpActions = new TableLayoutPanel();
        _btnBorrow = new Button();
        _btnReturn = new Button();
        _btnRead = new Button();
        _btnRest = new Button();
        _nudRestHours = new NumericUpDown();
        _lblRestHours = new Label();
        _grpLog = new GroupBox();
        _txtLog = new TextBox();

        _tlpMain.SuspendLayout();
        _tlpLeft.SuspendLayout();
        _grpLibrary.SuspendLayout();
        _grpAddBook.SuspendLayout();
        _tlpAddBook.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_nudPages).BeginInit();
        _tlpRight.SuspendLayout();
        _grpReader.SuspendLayout();
        _tlpReader.SuspendLayout();
        _grpActions.SuspendLayout();
        _tlpActions.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)_nudRestHours).BeginInit();
        _grpLog.SuspendLayout();
        SuspendLayout();

        // _tlpMain
        _tlpMain.ColumnCount = 2;
        _tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
        _tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
        _tlpMain.RowCount = 1;
        _tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        _tlpMain.Controls.Add(_tlpLeft, 0, 0);
        _tlpMain.Controls.Add(_tlpRight, 1, 0);
        _tlpMain.Dock = DockStyle.Fill;
        _tlpMain.Location = new Point(0, 0);
        _tlpMain.Size = new Size(800, 520);
        _tlpMain.Name = "_tlpMain";
        _tlpMain.Padding = new Padding(6);

        // _tlpLeft
        _tlpLeft.ColumnCount = 1;
        _tlpLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        _tlpLeft.RowCount = 2;
        _tlpLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        _tlpLeft.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _tlpLeft.Controls.Add(_grpLibrary, 0, 0);
        _tlpLeft.Controls.Add(_grpAddBook, 0, 1);
        _tlpLeft.Dock = DockStyle.Fill;
        _tlpLeft.Size = new Size(428, 508);
        _tlpLeft.Name = "_tlpLeft";

        // _grpLibrary
        _grpLibrary.Controls.Add(_lvBooks);
        _grpLibrary.Dock = DockStyle.Fill;
        _grpLibrary.Name = "_grpLibrary";
        _grpLibrary.Padding = new Padding(8);
        _grpLibrary.Size = new Size(428, 370);
        _grpLibrary.TabIndex = 0;
        _grpLibrary.TabStop = false;
        _grpLibrary.Text = "Library Books";

        // _lvBooks
        _lvBooks.Columns.AddRange(new ColumnHeader[] { _colTitle, _colPages });
        _lvBooks.Dock = DockStyle.Fill;
        _lvBooks.FullRowSelect = true;
        _lvBooks.Location = new Point(8, 24);
        _lvBooks.Name = "_lvBooks";
        _lvBooks.Size = new Size(412, 338);
        _lvBooks.TabIndex = 0;
        _lvBooks.View = View.Details;

        // _colTitle
        _colTitle.Text = "Title";
        _colTitle.Width = 250;

        // _colPages
        _colPages.Text = "Pages";
        _colPages.Width = 80;

        // _grpAddBook
        _grpAddBook.AutoSize = true;
        _grpAddBook.AutoSizeMode = AutoSizeMode.GrowOnly;
        _grpAddBook.Controls.Add(_tlpAddBook);
        _grpAddBook.Dock = DockStyle.Fill;
        _grpAddBook.Name = "_grpAddBook";
        _grpAddBook.Padding = new Padding(8);
        _grpAddBook.Size = new Size(428, 130);
        _grpAddBook.TabIndex = 1;
        _grpAddBook.TabStop = false;
        _grpAddBook.Text = "Add Book";

        // _tlpAddBook
        _tlpAddBook.AutoSize = true;
        _tlpAddBook.ColumnCount = 2;
        _tlpAddBook.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        _tlpAddBook.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        _tlpAddBook.RowCount = 3;
        _tlpAddBook.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _tlpAddBook.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _tlpAddBook.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _tlpAddBook.Controls.Add(_lblTitle, 0, 0);
        _tlpAddBook.Controls.Add(_txtTitle, 1, 0);
        _tlpAddBook.Controls.Add(_lblPages, 0, 1);
        _tlpAddBook.Controls.Add(_nudPages, 1, 1);
        _tlpAddBook.Controls.Add(_btnAddBook, 1, 2);
        _tlpAddBook.Dock = DockStyle.Fill;
        _tlpAddBook.Location = new Point(8, 24);
        _tlpAddBook.Size = new Size(412, 98);
        _tlpAddBook.Name = "_tlpAddBook";

        // _lblTitle
        _lblTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        _lblTitle.AutoSize = true;
        _lblTitle.Name = "_lblTitle";
        _lblTitle.Size = new Size(32, 15);
        _lblTitle.Text = "Title:";

        // _txtTitle
        _txtTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        _txtTitle.Name = "_txtTitle";
        _txtTitle.Size = new Size(370, 23);
        _txtTitle.Margin = new Padding(3);

        // _lblPages
        _lblPages.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        _lblPages.AutoSize = true;
        _lblPages.Name = "_lblPages";
        _lblPages.Size = new Size(38, 15);
        _lblPages.Text = "Pages:";

        // _nudPages
        _nudPages.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        _nudPages.Minimum = 1;
        _nudPages.Maximum = 10000;
        _nudPages.Value = 100;
        _nudPages.Name = "_nudPages";
        _nudPages.Size = new Size(370, 23);
        _nudPages.Margin = new Padding(3);

        // _btnAddBook
        _btnAddBook.Anchor = AnchorStyles.Right;
        _btnAddBook.AutoSize = true;
        _btnAddBook.Name = "_btnAddBook";
        _btnAddBook.Size = new Size(80, 25);
        _btnAddBook.Text = "Add Book";
        _btnAddBook.Margin = new Padding(3, 6, 3, 3);
        _btnAddBook.Click += BtnAddBook_Click;

        // _tlpRight
        _tlpRight.ColumnCount = 1;
        _tlpRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        _tlpRight.RowCount = 3;
        _tlpRight.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _tlpRight.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _tlpRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        _tlpRight.Controls.Add(_grpReader, 0, 0);
        _tlpRight.Controls.Add(_grpActions, 0, 1);
        _tlpRight.Controls.Add(_grpLog, 0, 2);
        _tlpRight.Dock = DockStyle.Fill;
        _tlpRight.Size = new Size(354, 508);
        _tlpRight.Name = "_tlpRight";

        // _grpReader
        _grpReader.AutoSize = true;
        _grpReader.AutoSizeMode = AutoSizeMode.GrowOnly;
        _grpReader.Controls.Add(_tlpReader);
        _grpReader.Dock = DockStyle.Fill;
        _grpReader.Name = "_grpReader";
        _grpReader.Padding = new Padding(8);
        _grpReader.Size = new Size(348, 140);
        _grpReader.TabIndex = 0;
        _grpReader.TabStop = false;
        _grpReader.Text = "Reader";

        // _tlpReader
        _tlpReader.AutoSize = true;
        _tlpReader.ColumnCount = 3;
        _tlpReader.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        _tlpReader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        _tlpReader.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
        _tlpReader.RowCount = 4;
        _tlpReader.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _tlpReader.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _tlpReader.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _tlpReader.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _tlpReader.Controls.Add(_lblReaderName, 0, 0);
        _tlpReader.Controls.Add(_cboReader, 1, 0);
        _tlpReader.SetColumnSpan(_cboReader, 2);
        _tlpReader.Controls.Add(_lblNewReader, 0, 1);
        _tlpReader.Controls.Add(_txtNewReaderName, 1, 1);
        _tlpReader.Controls.Add(_btnAddReader, 2, 1);
        _tlpReader.Controls.Add(_lblEnergy, 0, 2);
        _tlpReader.Controls.Add(_lblEnergyValue, 1, 2);
        _tlpReader.Controls.Add(_lblBooksRead, 0, 3);
        _tlpReader.Controls.Add(_lblBooksReadValue, 1, 3);
        _tlpReader.Dock = DockStyle.Fill;
        _tlpReader.Location = new Point(8, 24);
        _tlpReader.Size = new Size(332, 110);
        _tlpReader.Name = "_tlpReader";

        // _lblReaderName
        _lblReaderName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        _lblReaderName.AutoSize = true;
        _lblReaderName.Name = "_lblReaderName";
        _lblReaderName.Size = new Size(48, 15);
        _lblReaderName.Text = "Reader:";

        // _cboReader
        _cboReader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        _cboReader.DropDownStyle = ComboBoxStyle.DropDownList;
        _cboReader.Name = "_cboReader";
        _cboReader.Size = new Size(240, 23);
        _cboReader.Margin = new Padding(3);
        _cboReader.AccessibleName = "Select reader";
        _cboReader.SelectedIndexChanged += CboReader_SelectedIndexChanged;

        // _lblNewReader
        _lblNewReader.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        _lblNewReader.AutoSize = true;
        _lblNewReader.Name = "_lblNewReader";
        _lblNewReader.Size = new Size(48, 15);
        _lblNewReader.Text = "New:";

        // _txtNewReaderName
        _txtNewReaderName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        _txtNewReaderName.Name = "_txtNewReaderName";
        _txtNewReaderName.Size = new Size(200, 23);
        _txtNewReaderName.Margin = new Padding(3);

        // _btnAddReader
        _btnAddReader.AutoSize = true;
        _btnAddReader.Name = "_btnAddReader";
        _btnAddReader.Size = new Size(80, 25);
        _btnAddReader.Text = "Add";
        _btnAddReader.Margin = new Padding(3);
        _btnAddReader.Click += BtnAddReader_Click;
        _btnAddReader.AccessibleName = "Add new reader";

        // _lblEnergy
        _lblEnergy.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        _lblEnergy.AutoSize = true;
        _lblEnergy.Name = "_lblEnergy";
        _lblEnergy.Size = new Size(46, 15);
        _lblEnergy.Text = "Energy:";

        // _lblEnergyValue
        _lblEnergyValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        _lblEnergyValue.AutoSize = true;
        _lblEnergyValue.Name = "_lblEnergyValue";
        _lblEnergyValue.Size = new Size(284, 15);
        _lblEnergyValue.Text = "100";

        // _lblBooksRead
        _lblBooksRead.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        _lblBooksRead.AutoSize = true;
        _lblBooksRead.Name = "_lblBooksRead";
        _lblBooksRead.Size = new Size(70, 15);
        _lblBooksRead.Text = "Books read:";

        // _lblBooksReadValue
        _lblBooksReadValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        _lblBooksReadValue.AutoSize = true;
        _lblBooksReadValue.Name = "_lblBooksReadValue";
        _lblBooksReadValue.Size = new Size(284, 15);
        _lblBooksReadValue.Text = "0";

        // _grpActions
        _grpActions.AutoSize = true;
        _grpActions.AutoSizeMode = AutoSizeMode.GrowOnly;
        _grpActions.Controls.Add(_tlpActions);
        _grpActions.Dock = DockStyle.Fill;
        _grpActions.Name = "_grpActions";
        _grpActions.Padding = new Padding(8);
        _grpActions.Size = new Size(348, 100);
        _grpActions.TabIndex = 1;
        _grpActions.TabStop = false;
        _grpActions.Text = "Actions";

        // _tlpActions
        _tlpActions.AutoSize = true;
        _tlpActions.ColumnCount = 3;
        _tlpActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
        _tlpActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
        _tlpActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
        _tlpActions.RowCount = 2;
        _tlpActions.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _tlpActions.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        _tlpActions.Controls.Add(_btnBorrow, 0, 0);
        _tlpActions.Controls.Add(_btnReturn, 1, 0);
        _tlpActions.Controls.Add(_btnRead, 2, 0);
        _tlpActions.Controls.Add(_lblRestHours, 0, 1);
        _tlpActions.Controls.Add(_nudRestHours, 1, 1);
        _tlpActions.Controls.Add(_btnRest, 2, 1);
        _tlpActions.Dock = DockStyle.Fill;
        _tlpActions.Location = new Point(8, 24);
        _tlpActions.Size = new Size(332, 68);
        _tlpActions.Name = "_tlpActions";

        // _btnBorrow
        _btnBorrow.Dock = DockStyle.Fill;
        _btnBorrow.Name = "_btnBorrow";
        _btnBorrow.Size = new Size(104, 28);
        _btnBorrow.Text = "Borrow";
        _btnBorrow.Margin = new Padding(3);
        _btnBorrow.Click += BtnBorrow_Click;
        _btnBorrow.AccessibleName = "Borrow selected book";

        // _btnReturn
        _btnReturn.Dock = DockStyle.Fill;
        _btnReturn.Name = "_btnReturn";
        _btnReturn.Size = new Size(104, 28);
        _btnReturn.Text = "Return";
        _btnReturn.Margin = new Padding(3);
        _btnReturn.Click += BtnReturn_Click;
        _btnReturn.AccessibleName = "Return selected book";

        // _btnRead
        _btnRead.Dock = DockStyle.Fill;
        _btnRead.Name = "_btnRead";
        _btnRead.Size = new Size(104, 28);
        _btnRead.Text = "Read";
        _btnRead.Margin = new Padding(3);
        _btnRead.Click += BtnRead_Click;
        _btnRead.AccessibleName = "Read selected book";

        // _lblRestHours
        _lblRestHours.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        _lblRestHours.AutoSize = true;
        _lblRestHours.Name = "_lblRestHours";
        _lblRestHours.Size = new Size(104, 15);
        _lblRestHours.Text = "Rest hours:";

        // _nudRestHours
        _nudRestHours.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        _nudRestHours.Minimum = 1;
        _nudRestHours.Maximum = 24;
        _nudRestHours.Value = 1;
        _nudRestHours.Name = "_nudRestHours";
        _nudRestHours.Size = new Size(104, 23);
        _nudRestHours.Margin = new Padding(3);

        // _btnRest
        _btnRest.Dock = DockStyle.Fill;
        _btnRest.Name = "_btnRest";
        _btnRest.Size = new Size(104, 28);
        _btnRest.Text = "Rest";
        _btnRest.Margin = new Padding(3);
        _btnRest.Click += BtnRest_Click;
        _btnRest.AccessibleName = "Rest and regain energy";

        // _grpLog
        _grpLog.Controls.Add(_txtLog);
        _grpLog.Dock = DockStyle.Fill;
        _grpLog.Name = "_grpLog";
        _grpLog.Padding = new Padding(8);
        _grpLog.Size = new Size(348, 290);
        _grpLog.TabIndex = 2;
        _grpLog.TabStop = false;
        _grpLog.Text = "Log";

        // _txtLog
        _txtLog.Dock = DockStyle.Fill;
        _txtLog.Location = new Point(8, 24);
        _txtLog.Multiline = true;
        _txtLog.ReadOnly = true;
        _txtLog.ScrollBars = ScrollBars.Vertical;
        _txtLog.Name = "_txtLog";
        _txtLog.Size = new Size(332, 258);

        // MainForm
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 520);
        MinimumSize = new Size(640, 420);
        Controls.Add(_tlpMain);
        Name = "MainForm";
        Text = "Magic Library";

        _tlpMain.ResumeLayout(false);
        _tlpLeft.ResumeLayout(false);
        _tlpLeft.PerformLayout();
        _grpLibrary.ResumeLayout(false);
        _grpAddBook.ResumeLayout(false);
        _grpAddBook.PerformLayout();
        _tlpAddBook.ResumeLayout(false);
        _tlpAddBook.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_nudPages).EndInit();
        _tlpRight.ResumeLayout(false);
        _tlpRight.PerformLayout();
        _grpReader.ResumeLayout(false);
        _grpReader.PerformLayout();
        _tlpReader.ResumeLayout(false);
        _tlpReader.PerformLayout();
        _grpActions.ResumeLayout(false);
        _grpActions.PerformLayout();
        _tlpActions.ResumeLayout(false);
        _tlpActions.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)_nudRestHours).EndInit();
        _grpLog.ResumeLayout(false);
        _grpLog.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TableLayoutPanel _tlpMain;
    private TableLayoutPanel _tlpLeft;
    private GroupBox _grpLibrary;
    private ListView _lvBooks;
    private ColumnHeader _colTitle;
    private ColumnHeader _colPages;
    private GroupBox _grpAddBook;
    private TableLayoutPanel _tlpAddBook;
    private Label _lblTitle;
    private TextBox _txtTitle;
    private Label _lblPages;
    private NumericUpDown _nudPages;
    private Button _btnAddBook;
    private TableLayoutPanel _tlpRight;
    private GroupBox _grpReader;
    private TableLayoutPanel _tlpReader;
    private Label _lblReaderName;
    private ComboBox _cboReader;
    private Label _lblNewReader;
    private TextBox _txtNewReaderName;
    private Button _btnAddReader;
    private Label _lblEnergy;
    private Label _lblEnergyValue;
    private Label _lblBooksRead;
    private Label _lblBooksReadValue;
    private GroupBox _grpActions;
    private TableLayoutPanel _tlpActions;
    private Button _btnBorrow;
    private Button _btnReturn;
    private Button _btnRead;
    private Button _btnRest;
    private NumericUpDown _nudRestHours;
    private Label _lblRestHours;
    private GroupBox _grpLog;
    private TextBox _txtLog;
}
